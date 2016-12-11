using System;
using Xunit;

namespace VBR{
    public class UnixTimeTests{
        private readonly string _unixEpochFormat = "1970-01-{0:00}T{1:00}:{2:00}:{3:00}:{4:000}";
        private readonly string _assertFormat = "yyyy-MM-ddTHH:mm:ss:fff";

        [Fact]
        public void FromElapsedMillisecondsTest(){
            var ms = 300;

            var actual = UnixTime.FromElapsedMilliseconds(ms);            
        
            Assert.Equal(string.Format(_unixEpochFormat, 1, 0, 0, 0, ms), actual.ToString(_assertFormat));
        }

        [Fact]
        public void FromElapsedSecondsTest(){
            var s = 64;

            var actual = UnixTime.FromElapsedSecods(s);            

            Assert.Equal(string.Format(_unixEpochFormat, 1, 0, 1, 4, 0), actual.ToString(_assertFormat));
        }

        [Fact]
        public void FromElapsedMinutesTest(){
            var m = 72;

            var actual = UnixTime.FromElapsedMinutes(m);            
        
            Assert.Equal(string.Format(_unixEpochFormat, 1, 1, 12, 0, 0), actual.ToString(_assertFormat));
        }

        [Fact]
        public void FromElapsedMinutesHours(){
            var h = 27;

            var actual = UnixTime.FromElapsedHours(h);            
        
            Assert.Equal(string.Format(_unixEpochFormat, 2, 3, 0, 0, 0), actual.ToString(_assertFormat));
        }
    }
}