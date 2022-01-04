﻿using ErkerCore.Entities;
using ErkerCore.Library.Enums;
using ErkerCore.Message.Model;
using ErkerCore.View;

namespace ErkerCore.BusinessLogic.Managers
{
    public class SMEmploymentEntry : AbstractServiceManager<FeatureValue, ViewFeatureEmploymentEntry,BaseModel, ExtendEmploymentEntry>
    {
       public SMEmploymentEntry()
        {

            Target = Features.EmploymentEntry;
        }

    }
}
