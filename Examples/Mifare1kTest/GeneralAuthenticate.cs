﻿namespace Mifare1kTest
{
    public class GeneralAuthenticate
    {
        public byte Version { get; set; } = 0x01;

        public byte MSB { get; set; }
        public byte LSB { get; set; }
        public KeyType KeyType { get; set; }
        public byte KeyNumber { get; set; }

        public byte[] ToArray() {
            unchecked {
                return new[] {Version, MSB, LSB, (byte) KeyType, KeyNumber };
            }
        }
    }
}