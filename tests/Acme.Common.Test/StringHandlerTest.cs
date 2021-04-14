using System;
using Xunit;

namespace Acme.Common.Test
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewDriver";
            var expected = "Sonic Screw Driver";



            var actual = StringHandler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpaces()
        {
            var source = "Sonic ScrewDriver";
            var expected = "Sonic Screw Driver";


            var actual = StringHandler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }
    }
}
