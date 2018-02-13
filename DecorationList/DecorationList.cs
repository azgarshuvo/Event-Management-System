using System;

namespace Decoration
{
    public class DecorationList
    {
        private string decorationItem;
        private string decorationType;
        private string decorationCost;
        public DecorationList(string decorationType, string decorationCost)
        {
            this.decorationType = decorationType;
            this.decorationCost = decorationCost;
        }

        public DecorationList(string decorationItem, string decorationType, string decorationCost)
        {
            this.decorationItem = decorationItem;
            this.decorationType = decorationType;
            this.decorationCost = decorationCost;
        }
        public string DecorationItem
        {
            set { decorationItem = value; }
            get { return decorationItem; }
        }
        public string DecorationType
        {
            set { decorationType = value; }
            get { return decorationType; }
        }
        public string DecorationCost
        {
            set { decorationCost = value; }
            get { return decorationCost; }
        }
    }
}
