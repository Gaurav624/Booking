using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Bot.Connector.DirectLine;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BookingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            string botKey = "KKKsyCZiEnw.cwA.Ggw.7h4i9785moGqSXY9E85H4IxFbllh1K6aHkkKInMTspM";
            DirectLineClient client = new DirectLineClient(botKey, null);
            

            
        }

        private async void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string secret = "KKKsyCZiEnw.cwA.Ggw.7h4i9785moGqSXY9E85H4IxFbllh1K6aHkkKInMTspM";
            Microsoft.Bot.Connector.DirectLine.DirectLineClient client = new Microsoft.Bot.Connector.DirectLine.DirectLineClient(secret);
            var conversation = await client.Conversations.NewConversationWithHttpMessagesAsync();

            var message = new Microsoft.Bot.Connector.DirectLine.Models.Message();
            message.Text = "hi";
            message.ConversationId = conversation.Body.ConversationId;

            var result = await client.Conversations.PostMessageWithHttpMessagesAsync(conversation.Body.ConversationId, message);
            var messages = await client.Conversations.GetMessagesWithHttpMessagesAsync(message.ConversationId);

        }
    }
}
