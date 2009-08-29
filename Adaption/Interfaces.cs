﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

using GUIIntegration;

namespace Adaption
{
    public interface ICData : GUIIntegration.ICData
    {
        Image ResultImage { get; }
        Image SourceImage { get; }
        Image TargetImage { get; }
        Size OptimalImageSize { get; }
        Type MyType { get; }
        PropertyInfo[] PropertyList { get; }
    }

    public interface IMatchingAlgo : GUIIntegration.IMatchingAlgo
    {
        ICData Run(Image i_Image1, Image i_Image2, CProperty[] i_AlgorithmProps);

        void Create(Image i_SourceImage, Image i_TargetImage);
        Type MyType { get; }
        PropertyInfo[] PropertyList { get; }
        CProperty[] PropertyStrings { get; set; }
        ICData Run();
    }
}