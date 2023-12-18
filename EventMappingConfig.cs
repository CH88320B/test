TypeAdapterConfig<SdocAdapter.Root, Event>.ForType()
    .Map(dest => dest.AlertCategory, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertCategory : null)
    .Map(dest => dest.AlertCode, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertCode : null)
    .Map(dest => dest.AlertDescription, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertDescription : null)
    .Map(dest => dest.AlertResolved, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertResolved : null)
    .Map(dest => dest.AlertSource, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertSource : null)
    .Map(dest => dest.AlertStatus, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertStatus : null)
    .Map(dest => dest.CompanyID, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().CompanyID : null)
    .Map(dest => dest.DateUpdated, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().DateUpdated : null)
    .Map(dest => dest.Care_Patient_Account_Alerts_ID, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().Care_Patient_Account_Alerts_ID : null)
    .Map(dest => dest.EVN_UserID, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().EVN_UserID : null)
    .Map(dest => dest.NeboUserID, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().NeboUserID : null)
    .Map(dest => dest.ProductSource, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().ProductSource : null)
    .Map(dest => dest.Protocol, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().Protocol : null)
    // ... otras propiedades de Event ...
    .Map(dest => dest.BatchRowId, src => src.MessageEvent.BatchRowId)
    .Map(dest => dest.Deserializer, src => src.MessageHeader.Deserializer)
    .Map(dest => dest.DoNotOverWriteInsurance, src => src.MessageEvent.DoNotOverWriteInsurance)
    // ... otras configuraciones de mapeo ...
    .IgnoreNullValues(true); // Ignorar valores nulos al final para evitar problemas si todas las propiedades son nulas.


.Map(dest => dest.AlertCode, src => src.Alerts != null && src.Alerts.Any() ? src.Alerts.First().AlertCode : null, (dest, value) => dest.AlertCode = value as string)
