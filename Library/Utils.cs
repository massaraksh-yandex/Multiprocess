using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public static class Utils
    {

        public static string SettingsString(string filename,
                                            Decimal operationTime,
                                            Decimal timerValue,
                                            string timeEventName,
                                            int processId)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            
            builder.Append("--file=");
            builder.Append(filename);
            builder.Append(" ");

            builder.Append("--operation-time=");
            builder.Append(operationTime);
            builder.Append(" ");

            builder.Append("--timer-interval=");
            builder.Append(timerValue);
            builder.Append(" ");

            builder.Append("--wait-event-name=");
            builder.Append(timeEventName);
            builder.Append(" ");

            builder.Append("--process-id=");
            builder.Append(processId);
            builder.Append(" ");

            return builder.ToString();
        }

        public static string CreateTitle(ApplicationType app, Settings sett)
        {
            string str = "";
            switch (app)
            {
                case ApplicationType.ControllApp:
                    str = "Мультипроцессорное взаимодействие"; break;
                case ApplicationType.ReaderApp:
                    str = "Читатель " + sett.ProcessId; break;
                case ApplicationType.WriterApp:
                    str = "Писатель " + sett.ProcessId; break;
            }
            return str;
        }
    }
}
