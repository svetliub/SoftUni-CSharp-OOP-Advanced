using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;
using LoggerLibrary.Layouts;

namespace LoggerLibrary.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            ILayout layout = null;

            switch (layoutType)
            {
                case "SimpleLayout":
                    layout = new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout = new XmlLayout();
                    break;
                case "JsonLayout":
                    layout = new JsonLayout();
                    break;
                    default:
                        throw new ArgumentException("Invalid layout type!");
            }

            return layout;
        }
    }
}
