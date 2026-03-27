using System;
using System.Collections.Generic;
using System.Text;

namespace PR_7.LSP.Interfaces
{
    public interface IMailDoc // mailing the document after priting it
    {
        void Mail(string text);
    }
}
