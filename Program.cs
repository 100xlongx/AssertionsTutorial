using FluentAssertions;

namespace AssertionsImport
{
    public class handleAssertions {

        static void Main(string[] args)
        {

        }

        public void additionMethod() {
            var first = 3;
            var second = 7;
            var result = first + second;

            result.Should().Be(10);
        }
    }
}
