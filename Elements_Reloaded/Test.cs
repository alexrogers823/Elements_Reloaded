using System;
namespace Elements_Reloaded
{
    public class Test
    {
        private int _testNumber = 4;

        public Test()
        {
        }

        public string testMessage()
        {
            return $"Test message with int {_testNumber}";
        }
    }
}
