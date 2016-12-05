using System;
namespace VBR{

    /// <summary>
    /// Int extensions to get a DateTime object from the Unix Epoch (1970-01-01)
    /// (https://en.wikipedia.org/wiki/Unix_time)
    /// </summary>
    public static class UnixTimeExtensions{
        /// <summary>
        /// Returns a DateTime that is <paramref name="milliseconds" /> after the Unix Epoch  
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <returns></returns>
        public static DateTime MillisecondsSinceUnixEpoch(this int milliseconds){
            return UnixTime.FromElapsedMilliseconds(milliseconds);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="seconds" /> after the Unix Epoch
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime SecondsSinceUnixEpoch(this int seconds){
            return UnixTime.FromElapsedSecods(seconds);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="minutes" /> after the Unix Epoch
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public static DateTime MinutesSinceUnixEpoch(this int minutes){
            return UnixTime.FromElapsedMinutes(minutes);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="hours" /> after the Unix Epoch
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static DateTime HoursSinceUnixEpoch(this int hours){
            return UnixTime.FromElapsedHours(hours);
        }
    }
}
