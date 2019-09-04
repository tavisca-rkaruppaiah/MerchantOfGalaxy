using System;
using Xunit;

namespace MerchantOfGalaxy.Tests
{
    public class MechantOfGalaxyTest
    {
        [Fact]
        public void IsShouldReturn_pish_tegj_glob_glob_is_42()
        {
            var actual = Dialog.TypeOf("how much is pish tegj glob glob ?");
            var expected = "pish tegj glob glob is 42";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsShouldReturn_glob_prok_Silver_is_68_Credits()
        {
            var actual = Dialog.TypeOf("how many Credits is glob prok Silver ?");
            var expected = "glob prok Silver is 68 Credits";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsShouldReturn_glob_prok_Gold_is_57800_Credits()
        {
            var actual = Dialog.TypeOf("how many Credits is glob prok Gold ?");
            var expected = "glob prok Gold is 57800 Credits";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsShouldReturn_glob_prok_Iron_is_782_Credits()
        {
            var actual = Dialog.TypeOf("how many Credits is glob prok Iron ?");
            var expected = "glob prok Iron is 782 Credits";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsShouldReturn_I_have_no_idea_what_you_are_talking_about()
        {
            var actual = Dialog.TypeOf("how much wood could a woodchuck chuck if a woodchuck could chuck wood ?");
            var expected = "I have no idea what you are talking about";
            Assert.Equal(expected, actual);
        }

    }
}
