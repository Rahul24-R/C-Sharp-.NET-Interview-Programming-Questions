using System.Text;

namespace APIExtension.CodeFormatter
{
    public class CodeRead
    {
        private string codePath { get; set; }
        private string code { get; set; }
        public CodeRead(string codePath)
        {
            this.codePath = codePath;
        }

        public string EncodeCode()
        {
            code = File.ReadAllText(codePath);
            return code;
        }
    }
}
