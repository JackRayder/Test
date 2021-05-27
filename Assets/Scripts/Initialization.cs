using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Test
{
    public class Initialization : MonoBehaviour
    {
        public string value;

        public void CheckValue(int set, string name)
        {
            if (set == 1)
            {
                if (name == "LC_letters_1_0") value = "A";
                if (name == "LC_letters_1_1") value = "B";
                if (name == "LC_letters_1_2") value = "C";
                if (name == "LC_letters_1_3") value = "D";
                if (name == "LC_letters_1_4") value = "F";
                if (name == "LC_letters_1_5") value = "G";
                if (name == "LC_letters_1_6") value = "J";
                if (name == "LC_letters_1_7") value = "I";
                if (name == "LC_letters_1_8") value = "E";
                if (name == "LC_letters_1_9") value = "H";
                if (name == "LC_letters_1_10") value = "K";
                if (name == "LC_letters_1_11") value = "L";
                if (name == "LC_letters_1_12") value = "M";
                if (name == "LC_letters_2_0") value = "R";
                if (name == "LC_letters_2_1") value = "S";
                if (name == "LC_letters_2_2") value = "U";
                if (name == "LC_letters_2_3") value = "V";
                if (name == "LC_letters_2_4") value = "O";
                if (name == "LC_letters_2_5") value = "Q";
                if (name == "LC_letters_2_6") value = "W";
                if (name == "LC_letters_2_7") value = "T";
                if (name == "LC_letters_2_8") value = "N";
                if (name == "LC_letters_2_9") value = "P";
                if (name == "LC_letters_2_10") value = "X";
                if (name == "LC_letters_3_0") value = "Y";
                if (name == "LC_letters_3_1") value = "Z";
            }

            if (set == 2)
            {
                if (name == "SD_NC_Cookies_1_0") value = "1";
                if (name == "SD_NC_Cookies_1_1") value = "2";
                if (name == "SD_NC_Cookies_1_2") value = "3";
                if (name == "SD_NC_Cookies_1_3") value = "5";
                if (name == "SD_NC_Cookies_1_4") value = "4";
                if (name == "SD_NC_Cookies_1_5") value = "6";
                if (name == "SD_NC_Cookies_1_6") value = "7";
                if (name == "SD_NC_Cookies_1_7") value = "8";
                if (name == "SD_NC_Cookies_2_0") value = "9";
                if (name == "SD_NC_Cookies_3_0") value = "10";
            }
        }
    }
}