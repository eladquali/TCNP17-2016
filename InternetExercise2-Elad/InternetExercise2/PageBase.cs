﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace InternetExercise2
{
    public class PageBase : System.Web.UI.Page
    {
        public StateBag ReturnViewState => ViewState;
    }
}