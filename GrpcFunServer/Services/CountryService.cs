using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcFun.Services
{
    public class CountryService : Country.CountryBase
    {
        private readonly ILogger<GreeterService> _logger;
        public CountryService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<CountriesReply> GetAll(EmptyRequest request, ServerCallContext context)
        {
            var countriesReply = new CountriesReply
            {
                Countries = { countries }
            };

            _logger.LogTrace(countriesReply.ToString());

            return Task.FromResult(countriesReply);
        }

        private static readonly CountryReply[] countries = new[]
        {
            new CountryReply {Description = "Afghanistan", Name = "AF"},
            new CountryReply {Description = "Åland Islands", Name = "AX"},
            new CountryReply {Description = "Albania", Name = "AL"},
            new CountryReply {Description = "Algeria", Name = "DZ"},
            new CountryReply {Description = "American Samoa", Name = "AS"},
            new CountryReply {Description = "AndorrA", Name = "AD"},
            new CountryReply {Description = "Angola", Name = "AO"},
            new CountryReply {Description = "Anguilla", Name = "AI"},
            new CountryReply {Description = "Antarctica", Name = "AQ"},
            new CountryReply {Description = "Antigua and Barbuda", Name = "AG"},
            new CountryReply {Description = "Argentina", Name = "AR"},
            new CountryReply {Description = "Armenia", Name = "AM"},
            new CountryReply {Description = "Aruba", Name = "AW"},
            new CountryReply {Description = "Australia", Name = "AU"},
            new CountryReply {Description = "Austria", Name = "AT"},
            new CountryReply {Description = "Azerbaijan", Name = "AZ"},
            new CountryReply {Description = "Bahamas", Name = "BS"},
            new CountryReply {Description = "Bahrain", Name = "BH"},
            new CountryReply {Description = "Bangladesh", Name = "BD"},
            new CountryReply {Description = "Barbados", Name = "BB"},
            new CountryReply {Description = "Belarus", Name = "BY"},
            new CountryReply {Description = "Belgium", Name = "BE"},
            new CountryReply {Description = "Belize", Name = "BZ"},
            new CountryReply {Description = "Benin", Name = "BJ"},
            new CountryReply {Description = "Bermuda", Name = "BM"},
            new CountryReply {Description = "Bhutan", Name = "BT"},
            new CountryReply {Description = "Bolivia", Name = "BO"},
            new CountryReply {Description = "Bosnia and Herzegovina", Name = "BA"},
            new CountryReply {Description = "Botswana", Name = "BW"},
            new CountryReply {Description = "Bouvet Island", Name = "BV"},
            new CountryReply {Description = "Brazil", Name = "BR"},
            new CountryReply {Description = "British Indian Ocean Territory", Name = "IO"},
            new CountryReply {Description = "Brunei Darussalam", Name = "BN"},
            new CountryReply {Description = "Bulgaria", Name = "BG"},
            new CountryReply {Description = "Burkina Faso", Name = "BF"},
            new CountryReply {Description = "Burundi", Name = "BI"},
            new CountryReply {Description = "Cambodia", Name = "KH"},
            new CountryReply {Description = "Cameroon", Name = "CM"},
            new CountryReply {Description = "Canada", Name = "CA"},
            new CountryReply {Description = "Cape Verde", Name = "CV"},
            new CountryReply {Description = "Cayman Islands", Name = "KY"},
            new CountryReply {Description = "Central African Republic", Name = "CF"},
            new CountryReply {Description = "Chad", Name = "TD"},
            new CountryReply {Description = "Chile", Name = "CL"},
            new CountryReply {Description = "China", Name = "CN"},
            new CountryReply {Description = "Christmas Island", Name = "CX"},
            new CountryReply {Description = "Cocos (Keeling) Islands", Name = "CC"},
            new CountryReply {Description = "Colombia", Name = "CO"},
            new CountryReply {Description = "Comoros", Name = "KM"},
            new CountryReply {Description = "Congo", Name = "CG"},
            new CountryReply {Description = "Congo, The Democratic Republic of the", Name = "CD"},
            new CountryReply {Description = "Cook Islands", Name = "CK"},
            new CountryReply {Description = "Costa Rica", Name = "CR"},
            new CountryReply {Description = "Cote D\"Ivoire", Name = "CI"},
            new CountryReply {Description = "Croatia", Name = "HR"},
            new CountryReply {Description = "Cuba", Name = "CU"},
            new CountryReply {Description = "Cyprus", Name = "CY"},
            new CountryReply {Description = "Czech Republic", Name = "CZ"},
            new CountryReply {Description = "Denmark", Name = "DK"},
            new CountryReply {Description = "Djibouti", Name = "DJ"},
            new CountryReply {Description = "Dominica", Name = "DM"},
            new CountryReply {Description = "Dominican Republic", Name = "DO"},
            new CountryReply {Description = "Ecuador", Name = "EC"},
            new CountryReply {Description = "Egypt", Name = "EG"},
            new CountryReply {Description = "El Salvador", Name = "SV"},
            new CountryReply {Description = "Equatorial Guinea", Name = "GQ"},
            new CountryReply {Description = "Eritrea", Name = "ER"},
            new CountryReply {Description = "Estonia", Name = "EE"},
            new CountryReply {Description = "Ethiopia", Name = "ET"},
            new CountryReply {Description = "Falkland Islands (Malvinas)", Name = "FK"},
            new CountryReply {Description = "Faroe Islands", Name = "FO"},
            new CountryReply {Description = "Fiji", Name = "FJ"},
            new CountryReply {Description = "Finland", Name = "FI"},
            new CountryReply {Description = "France", Name = "FR"},
            new CountryReply {Description = "French Guiana", Name = "GF"},
            new CountryReply {Description = "French Polynesia", Name = "PF"},
            new CountryReply {Description = "French Southern Territories", Name = "TF"},
            new CountryReply {Description = "Gabon", Name = "GA"},
            new CountryReply {Description = "Gambia", Name = "GM"},
            new CountryReply {Description = "Georgia", Name = "GE"},
            new CountryReply {Description = "Germany", Name = "DE"},
            new CountryReply {Description = "Ghana", Name = "GH"},
            new CountryReply {Description = "Gibraltar", Name = "GI"},
            new CountryReply {Description = "Greece", Name = "GR"},
            new CountryReply {Description = "Greenland", Name = "GL"},
            new CountryReply {Description = "Grenada", Name = "GD"},
            new CountryReply {Description = "Guadeloupe", Name = "GP"},
            new CountryReply {Description = "Guam", Name = "GU"},
            new CountryReply {Description = "Guatemala", Name = "GT"},
            new CountryReply {Description = "Guernsey", Name = "GG"},
            new CountryReply {Description = "Guinea", Name = "GN"},
            new CountryReply {Description = "Guinea-Bissau", Name = "GW"},
            new CountryReply {Description = "Guyana", Name = "GY"},
            new CountryReply {Description = "Haiti", Name = "HT"},
            new CountryReply {Description = "Heard Island and Mcdonald Islands", Name = "HM"},
            new CountryReply {Description = "Holy See (Vatican City State)", Name = "VA"},
            new CountryReply {Description = "Honduras", Name = "HN"},
            new CountryReply {Description = "Hong Kong", Name = "HK"},
            new CountryReply {Description = "Hungary", Name = "HU"},
            new CountryReply {Description = "Iceland", Name = "IS"},
            new CountryReply {Description = "India", Name = "IN"},
            new CountryReply {Description = "Indonesia", Name = "ID"},
            new CountryReply {Description = "Iran, Islamic Republic Of", Name = "IR"},
            new CountryReply {Description = "Iraq", Name = "IQ"},
            new CountryReply {Description = "Ireland", Name = "IE"},
            new CountryReply {Description = "Isle of Man", Name = "IM"},
            new CountryReply {Description = "Israel", Name = "IL"},
            new CountryReply {Description = "Italy", Name = "IT"},
            new CountryReply {Description = "Jamaica", Name = "JM"},
            new CountryReply {Description = "Japan", Name = "JP"},
            new CountryReply {Description = "Jersey", Name = "JE"},
            new CountryReply {Description = "Jordan", Name = "JO"},
            new CountryReply {Description = "Kazakhstan", Name = "KZ"},
            new CountryReply {Description = "Kenya", Name = "KE"},
            new CountryReply {Description = "Kiribati", Name = "KI"},
            new CountryReply {Description = "Korea, Democratic People\"S Republic of", Name = "KP"},
            new CountryReply {Description = "Korea, Republic of", Name = "KR"},
            new CountryReply {Description = "Kuwait", Name = "KW"},
            new CountryReply {Description = "Kyrgyzstan", Name = "KG"},
            new CountryReply {Description = "Lao People\"S Democratic Republic", Name = "LA"},
            new CountryReply {Description = "Latvia", Name = "LV"},
            new CountryReply {Description = "Lebanon", Name = "LB"},
            new CountryReply {Description = "Lesotho", Name = "LS"},
            new CountryReply {Description = "Liberia", Name = "LR"},
            new CountryReply {Description = "Libyan Arab Jamahiriya", Name = "LY"},
            new CountryReply {Description = "Liechtenstein", Name = "LI"},
            new CountryReply {Description = "Lithuania", Name = "LT"},
            new CountryReply {Description = "Luxembourg", Name = "LU"},
            new CountryReply {Description = "Macao", Name = "MO"},
            new CountryReply {Description = "Macedonia, The Former Yugoslav Republic of", Name = "MK"},
            new CountryReply {Description = "Madagascar", Name = "MG"},
            new CountryReply {Description = "Malawi", Name = "MW"},
            new CountryReply {Description = "Malaysia", Name = "MY"},
            new CountryReply {Description = "Maldives", Name = "MV"},
            new CountryReply {Description = "Mali", Name = "ML"},
            new CountryReply {Description = "Malta", Name = "MT"},
            new CountryReply {Description = "Marshall Islands", Name = "MH"},
            new CountryReply {Description = "Martinique", Name = "MQ"},
            new CountryReply {Description = "Mauritania", Name = "MR"},
            new CountryReply {Description = "Mauritius", Name = "MU"},
            new CountryReply {Description = "Mayotte", Name = "YT"},
            new CountryReply {Description = "Mexico", Name = "MX"},
            new CountryReply {Description = "Micronesia, Federated States of", Name = "FM"},
            new CountryReply {Description = "Moldova, Republic of", Name = "MD"},
            new CountryReply {Description = "Monaco", Name = "MC"},
            new CountryReply {Description = "Mongolia", Name = "MN"},
            new CountryReply {Description = "Montserrat", Name = "MS"},
            new CountryReply {Description = "Morocco", Name = "MA"},
            new CountryReply {Description = "Mozambique", Name = "MZ"},
            new CountryReply {Description = "Myanmar", Name = "MM"},
            new CountryReply {Description = "Namibia", Name = "NA"},
            new CountryReply {Description = "Nauru", Name = "NR"},
            new CountryReply {Description = "Nepal", Name = "NP"},
            new CountryReply {Description = "Netherlands", Name = "NL"},
            new CountryReply {Description = "Netherlands Antilles", Name = "AN"},
            new CountryReply {Description = "New Caledonia", Name = "NC"},
            new CountryReply {Description = "New Zealand", Name = "NZ"},
            new CountryReply {Description = "Nicaragua", Name = "NI"},
            new CountryReply {Description = "Niger", Name = "NE"},
            new CountryReply {Description = "Nigeria", Name = "NG"},
            new CountryReply {Description = "Niue", Name = "NU"},
            new CountryReply {Description = "Norfolk Island", Name = "NF"},
            new CountryReply {Description = "Northern Mariana Islands", Name = "MP"},
            new CountryReply {Description = "Norway", Name = "NO"},
            new CountryReply {Description = "Oman", Name = "OM"},
            new CountryReply {Description = "Pakistan", Name = "PK"},
            new CountryReply {Description = "Palau", Name = "PW"},
            new CountryReply {Description = "Palestinian Territory, Occupied", Name = "PS"},
            new CountryReply {Description = "Panama", Name = "PA"},
            new CountryReply {Description = "Papua New Guinea", Name = "PG"},
            new CountryReply {Description = "Paraguay", Name = "PY"},
            new CountryReply {Description = "Peru", Name = "PE"},
            new CountryReply {Description = "Philippines", Name = "PH"},
            new CountryReply {Description = "Pitcairn", Name = "PN"},
            new CountryReply {Description = "Poland", Name = "PL"},
            new CountryReply {Description = "Portugal", Name = "PT"},
            new CountryReply {Description = "Puerto Rico", Name = "PR"},
            new CountryReply {Description = "Qatar", Name = "QA"},
            new CountryReply {Description = "Reunion", Name = "RE"},
            new CountryReply {Description = "Romania", Name = "RO"},
            new CountryReply {Description = "Russian Federation", Name = "RU"},
            new CountryReply {Description = "RWANDA", Name = "RW"},
            new CountryReply {Description = "Saint Helena", Name = "SH"},
            new CountryReply {Description = "Saint Kitts and Nevis", Name = "KN"},
            new CountryReply {Description = "Saint Lucia", Name = "LC"},
            new CountryReply {Description = "Saint Pierre and Miquelon", Name = "PM"},
            new CountryReply {Description = "Saint Vincent and the Grenadines", Name = "VC"},
            new CountryReply {Description = "Samoa", Name = "WS"},
            new CountryReply {Description = "San Marino", Name = "SM"},
            new CountryReply {Description = "Sao Tome and Principe", Name = "ST"},
            new CountryReply {Description = "Saudi Arabia", Name = "SA"},
            new CountryReply {Description = "Senegal", Name = "SN"},
            new CountryReply {Description = "Serbia and Montenegro", Name = "CS"},
            new CountryReply {Description = "Seychelles", Name = "SC"},
            new CountryReply {Description = "Sierra Leone", Name = "SL"},
            new CountryReply {Description = "Singapore", Name = "SG"},
            new CountryReply {Description = "Slovakia", Name = "SK"},
            new CountryReply {Description = "Slovenia", Name = "SI"},
            new CountryReply {Description = "Solomon Islands", Name = "SB"},
            new CountryReply {Description = "Somalia", Name = "SO"},
            new CountryReply {Description = "South Africa", Name = "ZA"},
            new CountryReply {Description = "South Georgia and the South Sandwich Islands", Name = "GS"},
            new CountryReply {Description = "Spain", Name = "ES"},
            new CountryReply {Description = "Sri Lanka", Name = "LK"},
            new CountryReply {Description = "Sudan", Name = "SD"},
            new CountryReply {Description = "Suriname", Name = "SR"},
            new CountryReply {Description = "Svalbard and Jan Mayen", Name = "SJ"},
            new CountryReply {Description = "Swaziland", Name = "SZ"},
            new CountryReply {Description = "Sweden", Name = "SE"},
            new CountryReply {Description = "Switzerland", Name = "CH"},
            new CountryReply {Description = "Syrian Arab Republic", Name = "SY"},
            new CountryReply {Description = "Taiwan, Province of China", Name = "TW"},
            new CountryReply {Description = "Tajikistan", Name = "TJ"},
            new CountryReply {Description = "Tanzania, United Republic of", Name = "TZ"},
            new CountryReply {Description = "Thailand", Name = "TH"},
            new CountryReply {Description = "Timor-Leste", Name = "TL"},
            new CountryReply {Description = "Togo", Name = "TG"},
            new CountryReply {Description = "Tokelau", Name = "TK"},
            new CountryReply {Description = "Tonga", Name = "TO"},
            new CountryReply {Description = "Trinidad and Tobago", Name = "TT"},
            new CountryReply {Description = "Tunisia", Name = "TN"},
            new CountryReply {Description = "Turkey", Name = "TR"},
            new CountryReply {Description = "Turkmenistan", Name = "TM"},
            new CountryReply {Description = "Turks and Caicos Islands", Name = "TC"},
            new CountryReply {Description = "Tuvalu", Name = "TV"},
            new CountryReply {Description = "Uganda", Name = "UG"},
            new CountryReply {Description = "Ukraine", Name = "UA"},
            new CountryReply {Description = "United Arab Emirates", Name = "AE"},
            new CountryReply {Description = "United Kingdom", Name = "GB"},
            new CountryReply {Description = "United States", Name = "US"},
            new CountryReply {Description = "United States Minor Outlying Islands", Name = "UM"},
            new CountryReply {Description = "Uruguay", Name = "UY"},
            new CountryReply {Description = "Uzbekistan", Name = "UZ"},
            new CountryReply {Description = "Vanuatu", Name = "VU"},
            new CountryReply {Description = "Venezuela", Name = "VE"},
            new CountryReply {Description = "Viet Nam", Name = "VN"},
            new CountryReply {Description = "Virgin Islands, British", Name = "VG"},
            new CountryReply {Description = "Virgin Islands, U.S.", Name = "VI"},
            new CountryReply {Description = "Wallis and Futuna", Name = "WF"},
            new CountryReply {Description = "Western Sahara", Name = "EH"},
            new CountryReply {Description = "Yemen", Name = "YE"},
            new CountryReply {Description = "Zambia", Name = "ZM"},
            new CountryReply {Description = "Zimbabwe", Name = "ZW"}
        };    
    }
}
