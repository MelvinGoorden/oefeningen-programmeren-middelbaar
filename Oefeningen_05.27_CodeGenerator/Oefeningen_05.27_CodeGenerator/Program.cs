using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_05._27_CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string boodschap = "";
            string geheimschrift = "";

            foreach (char waarde in boodschap)
            {
                switch (waarde)
                {
                    case 'a':
                    {
                        geheimschrift += '¨';
                        break;
                    }
                    case 'b':
                        {
                            geheimschrift += '^';
                            break;
                        }
                    case 'c':
                        {
                            geheimschrift += '[';
                            break;
                        }
                    case 'd':
                        {
                            geheimschrift += '$';
                            break;
                        }
                    case 'e':
                        {
                            geheimschrift += '*';
                            break;
                        }
                    case 'f':
                        {
                            geheimschrift += ']';
                            break;
                        }
                    case 'g':
                        {
                            geheimschrift += 'ù';
                            break;
                        }
                    case 'h':
                        {
                            geheimschrift += '%';
                            break;
                        }
                    case 'i':
                        {
                            geheimschrift += '´';
                            break;
                        }
                    case 'j':
                        {
                            geheimschrift += 'µ';
                            break;
                        }
                    case 'k':
                        {
                            geheimschrift += '£';
                            break;
                        }
                    case 'l':
                        {
                            geheimschrift += '`';
                            break;
                        }
                    case 'm':
                        {
                            geheimschrift += '?';
                            break;
                        }
                    case 'n':
                        {
                            geheimschrift += ',';
                            break;
                        }
                    case 'o':
                        {
                            geheimschrift += '&';
                            break;
                        }
                    case 'p':
                        {
                            geheimschrift += '|';
                            break;
                        }
                    case 'q':
                        {
                            geheimschrift += 'é';
                            break;
                        }
                    case 'r':
                        {
                            geheimschrift += '@';
                            break;
                        }
                    case 's':
                        {
                            geheimschrift += '"';
                            break;
                        }
                    case 't':
                        {
                            geheimschrift += '#';
                            break;
                        }
                    case 'u':
                        {
                            geheimschrift += '(';
                            break;
                        }
                    case 'v':
                        {
                            geheimschrift += '§';
                            break;
                        }
                    case 'w':
                        {
                            geheimschrift += 'ç';
                            break;
                        }
                    case 'x':
                        {
                            geheimschrift += '-';
                            break;
                        }
                    case 'y':
                        {
                            geheimschrift += ')';
                            break;
                        }
                }
            }
        }
    }
}
