﻿using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Tokenizer_2
{
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance;

        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("tf0Rh7vTM/eXQV/HHorTXUj+Ir+HBgKLGQR2UscISsD1ztEzj5vhYuW10B1+aVnJd22nLTPtuQdzRqOFsniVQJRojJ6gJPvFUVT5jAB6y2/hkKewgZ7yGANj5gjn8OL85CSs774LvrgVQQJCTtHqhD+RLWqZux66P5KQzE9uwefbcFskbu7+n0mRkR9JLHVpPNK7XFUrlTz/u6wZfxgMBmYnk/Bbnlr55KD5AcmnCs9qkr+dlWh6D/cptwxxDtLSFRnG5ec1ZYJHCQbI813jfdlIj5sy6HMy79fznWG4jJFOiW8YwjhpGMYWquTLSiYH2H69VPTlnopjE78vG9qq816E6VDpGMX57EtBgXUOef3JWz+hviJAerednFuVoRTrSUFuakOI8wKy2BfTBJDnQPggUUR2hxczEmmXM3Ky7MtZwY0JAQPHTkGQZmFwulgdp6P85n+FaDwIYGlxsNBS0TOWdmytneoXkYr8jQZEajPBAIMUtMqQNVPFCbaNk2S5g6C6/6HrniaHRQvW8HveLaz95R5toovlH5HB+JAgKLh2flY/Dys6mIYIs6eyOuWOlm5Oux2WYRN3ZlXzjY+V/3Juq2rYSCwouwNeFph+avsT0V2WhXrc+2UrBACdZpwwdKf91gej6vinSqvA8j6sY+qbczwa7AW7opjwzUc0FBdVaK6CxE7SGC0iJibo5QKGnJ9NRDfabUTFlPERe0ov7dsVw2hiaVah0eiyaX01yOsmkse5GRUm+CSpdm/UrgjDii14omuZdgKG0qTkac+Tjjes85CSwlkL6xlaOwSoGSnjcXcxANZmCeCmEY1F2JENamd+crYiBm+6cnV+lXml9ISBEiWtuWHqKjvdmnQWYBnKowav7Bs2SWHJHkCR8Wu4UqDfoT1e7jN9OmCJ/hRNqEQk1UrBS28NG1cdetQbs5Zmq6o1uftbro2tc2vQrt7ucu758KX2mfvnegtCXxiu76hr/qZEtnp77S8x03eBIh+7boH85XwihcrNo+U/5EmOypaSnX/XImTgCv2ONCTImhnGfAqx2ozZ08pXsqOdFFPRXCZx48jWj4Sit9+VLCQwNyh1J9IxqoFuWrFyb+d9R7rAe/jbgrrwThsFFjmlzOeUzZ8gXBwRW2in/ytTr/4nVRC8dzDDO5jg5bu2GJ8r+3tClD9NKA9rzPmAwpvrvCf7luRbuJQetRLuVbeVECS7ABwLqZdU4ycAVINRYhleuE0xPQDsbfKQo4k7Q9NJSc8zGlJYZpHV+PyH6qv+bVxcTtRnMd1K4zZNfBWnyqal9SlZdNHJd4to8vDvw8+99CZ2wNMUz5JI0IBEFXFiwTa35SXiWbEgzOMt9Au4IFTaNg==")]
        public string CepKey
        {
            get
            {
                return (string)this["CepKey"];
            }
        }

        [ApplicationScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("sKptyag8ZTxSPIJre77dOoWkCD9rp35jH1bAdyKBVx5tTr/T+eNSqHOTJHbxNc4ELRmaanXKmmBFKO9DVegA4387Of79SMDZAzlffw9yI2XJb3Y+49g8PrRck3G6aKFEPOPzxp5jORNFSM03Mkrk2YyHv73ln1PY+B4lb0yI5PimMhr+HgSQ5tUCNkz12cvnltqroivMT3PPy3cNQMaAVPQ2ZSsBwXU/BhHlc+7QEkgiEyxpq2QhRolQksvAEWFrVN44UE3DPz2JtuzSLYDP4yAZRxcpU9o8fInBKetPrJE+SrtNqjMEc4r7wx2i0D3aEFCX6WOUbz3RcW/l8ImlMQ==")]
        public string CepSalt
        {
            get
            {
                return (string)this["CepSalt"];
            }
        }

        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }

        static Settings()
        {
            Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
        }

        public Settings()
        {
        }
    }
}
