namespace Customers
{
    internal class NavigationArgs
    {
        internal string customerName { get; }
        internal string commandMode { get; }

        public NavigationArgs(string customerName, string commandMode)
        {
            this.customerName = customerName;
            this.commandMode = commandMode;
        }
    }
}