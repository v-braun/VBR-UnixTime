using System;

namespace VBR{
    /// <summary>
    /// Converts UnixEpoch Date information to DateTime
    /// </summary>
    public static class UnixTime{
        private readonly static DateTime UNIX_EPOCH = new DateTime(1970, 1, 1);
        
        /// <summary>
        /// Base UNIX Epoch DateTime
        /// </summary>
        /// <returns>Base UNIX Epoch as DateTime</returns>
        public static DateTime UnixEpoch { get{return UNIX_EPOCH;} }
        /// <summary>
        /// Returns a DateTime that is <paramref name="milliseconds" /> after the Unix Epoch
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <returns></returns>
        public static DateTime FromElapsedMilliseconds(int milliseconds){
            return UNIX_EPOCH.AddMilliseconds(milliseconds);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="seconds" /> after the Unix Epoch
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime FromElapsedSecods(int seconds){
            return UNIX_EPOCH.AddSeconds(seconds);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="minutes" /> after the Unix Epoch
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public static DateTime FromElapsedMinutes(int minutes){
            return UNIX_EPOCH.AddMinutes(minutes);
        }
        /// <summary>
        /// Returns a DateTime that is <paramref name="hours" /> after the Unix Epoch
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static DateTime FromElapsedHours(int hours){
            return UNIX_EPOCH.AddHours(hours);
        }
    }
}