﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace ASD.ESH.Common {

    internal static class TypesFormats {

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = Constants.Parameter.TypeName)]
        [Name(Constants.Parameter.FormatName)]
        [UserVisible(true)]
        [Order(After = Priority.High)]
        internal sealed class ParameterFormat : ClassificationFormatDefinition {

            public ParameterFormat() {
                DisplayName = Constants.Parameter.DisplayName;
                ForegroundColor = Colors.Gray;
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = Constants.Property.TypeName)]
        [Name(Constants.Property.FormatName)]
        [UserVisible(true)]
        [Order(After = Priority.High)]
        internal sealed class PropertyFormat : ClassificationFormatDefinition {

            public PropertyFormat() {
                DisplayName = Constants.Property.DisplayName;
                ForegroundColor = Colors.LightBlue;
            }
        }
    }
}