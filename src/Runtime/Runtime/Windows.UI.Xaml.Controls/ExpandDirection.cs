﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;

#if MIGRATION
namespace System.Windows.Controls
#else
namespace Windows.UI.Xaml.Controls
#endif
{
    /// <summary>
    /// Specifies the direction in which an
    /// <see cref="Expander" /> control opens.
    /// </summary>
    /// <QualityBand>Stable</QualityBand>
    public enum ExpandDirection
    {
        /// <summary>
        /// Specifies that the <see cref="Expander" />
        /// control opens in the down direction.
        /// </summary>
        Down = 0,

        /// <summary>
        /// Specifies that the <see cref="Expander" />
        /// control opens in the up direction.
        /// </summary>
        Up = 1,

        /// <summary>
        /// Specifies that the <see cref="Expander" />
        /// control opens in the left direction.
        /// </summary>
        Left = 2,

        /// <summary>
        /// Specifies that the <see cref="Expander" />
        /// control opens in the right direction.
        /// </summary>
        Right = 3,
    }
}
