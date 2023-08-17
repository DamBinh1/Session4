using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc.demo4
{
    public delegate void ActionDelegate(string arg);

    public class Button
    {
        public event ActionDelegate Click;
        public Button(ActionDelegate onAction)
        {
            Click += onAction;   
        }
    }
}
    