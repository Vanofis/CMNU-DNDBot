using System;
using System.Threading;
using System.Threading.Tasks;
using DND_Bot_States;
using DND_Bot_States.States;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Polling;
using Telegram.Bot.Exceptions;
using DND_Bot.FileManagement;

namespace VadimDNDBot;

class Program
{
    private const string Token = "8170360935:AAEJ_KIME3pofAGSqVtMPEuZk8XIRxBlXfM";
    private static ITelegramBotClient BotClient;
    private static ReceiverOptions ReceiverOptions;
    
    private static async Task Main()
    {
        ImageLibrary.Initialize();
        StateFileManager.Initialize();
        
        BotClient = new TelegramBotClient(Token);
        ReceiverOptions = new ReceiverOptions
        {
            AllowedUpdates =
            [
                UpdateType.Message,
                UpdateType.CallbackQuery,
            ],
            DropPendingUpdates = true, 
        };
        using var cancellationTokenSource = new CancellationTokenSource();
        
        BotClient.StartReceiving(UpdateHandler, ErrorHandler, ReceiverOptions, cancellationTokenSource.Token);
        
        var me = await BotClient.GetMe(cancellationTokenSource.Token);
        Console.WriteLine($"{me.FirstName} is online!");

        await Task.Delay(-1, cancellationTokenSource.Token);
    }
    
    private static async Task UpdateHandler(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        try
        {
            var message = update.Message;
            var chat = message.Chat;
            
            switch (update.Type)
            {
                case UpdateType.Message:
                {
                    if (message.Text == "/start")
                    {
                        StateMachine.SetState(StateFileManager.GetState("NurseHere.xml"));
                        string path = StateMachine.CurrentState.SubStates[StateMachine.CurrentState.CurrentSubStateIndex]
                            .ImagePath;
                        using var memoryStream = ImageLibrary.GetImage(path);
                        
                        await botClient.SendPhoto(
                            chatId: chat.Id, 
                            photo: new InputFileStream(memoryStream, path),
                            caption: StateMachine.CurrentState.SubStates[StateMachine.CurrentState.CurrentSubStateIndex].Message,
                            replyMarkup: StateMachine.CurrentState.SubStates[StateMachine.CurrentState.CurrentSubStateIndex].Buttons.GetMarkup()
                            );

                    }
                }
                    break;
                case UpdateType.CallbackQuery:
                {
                    
                }
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static Task ErrorHandler(ITelegramBotClient botClient, Exception error, CancellationToken cancellationToken)
    {
        var errorMessage = error switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => error.ToString()
        };

        Console.WriteLine(errorMessage);
        return Task.CompletedTask;
    }
}