namespace xEmilForms.Exception
{
    public class NoViewException : System.Exception
    {
        public NoViewException()
        {
        }

        public NoViewException(string message) : base(message)
        {
        }

        public NoViewException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}