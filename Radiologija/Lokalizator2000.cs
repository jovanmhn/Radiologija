using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;

namespace Radiologija
{
    public class Lokalizator2000 : Localizer
    {
        public override string GetLocalizedString(StringId id)
        {
            if (id == StringId.XtraMessageBoxYesButtonText)
                return "Da";
            if (id == StringId.XtraMessageBoxNoButtonText)
                return "Ne";
            if (id == StringId.XtraMessageBoxCancelButtonText)
                return "Poništi";
            if (id == StringId.XtraMessageBoxOkButtonText)
                return "U redu";
            return base.GetLocalizedString(id);
        }
    }
}
