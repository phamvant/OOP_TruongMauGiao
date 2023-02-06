using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
    public class MessageInfo
    {
        public string _senderId;
        public string _receiverId;
        public string _content;

        public bool send()
        {
            MySqlCommand command = CommandGenerator.addMessage(this);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }
    }
}
