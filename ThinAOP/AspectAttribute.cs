﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThinAOP
{    
    public abstract class AspectAttribute : Attribute
    {
        public virtual void Action(InvokeContext context) { }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public abstract class PreAspectAttribute : AspectAttribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public abstract class PostAspectAttribute : AspectAttribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public abstract class ExceptionAspectAttribute : AspectAttribute
    {
    }
}
