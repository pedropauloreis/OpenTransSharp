﻿using System;
using System.Collections.Generic;

namespace OpenTransSharp.Tests.ReceiptAcknowledgements
{
    internal class ReceiptAcknowledgementTestConfig
    {
        private TestConfig parent;

        public ReceiptAcknowledgementTestConfig(TestConfig parent)
        {
            this.parent = parent;
        }

        public ReceiptAcknowledgement GetReceiptAcknowledgement()
        {
            var model = new ReceiptAcknowledgement();

            model.Header = GetHeader();

            model.Items.Add(GetReceiptAcknowledgementItem());

            model.Summary = GetSummary();

            return model;
        }

        private ReceiptAcknowledgementSummary GetSummary()
        {
            var model = new ReceiptAcknowledgementSummary();

            model.TotalItemCount = 1;

            return model;
        }

        private ReceiptAcknowledgementItem GetReceiptAcknowledgementItem()
        {
            var model = new ReceiptAcknowledgementItem();

            model.LineItemId = "1";
            model.OrderUnit = "C62";
            model.Quantity = 2;
            model.Remarks = new List<Remark>
            {
                new Remark("Be careful", RemarkTypeValues.DeliveryNote)
            };
            model.ProductId = new ProductId
            {
                SupplierPid = new SupplierPid("Supplier ProductId", SupplierPidTypeValues.SupplierSpecific),
                ProductType = ProductTypeValues.Physical,
                SupplierIdref = GetSupplierIdRef()
            };

            return model;
        }

        private ReceiptAcknowledgementHeader GetHeader()
        {
            var header = new ReceiptAcknowledgementHeader();

            header.ControlInformation = GetControlInformation();

            header.Information = GetReceiptAcknowledgementInformation();

            return header;
        }

        private ReceiptAcknowledgementInformation GetReceiptAcknowledgementInformation()
        {
            var model = new ReceiptAcknowledgementInformation();

            model.DocexchangePartiesReference = new DocexchangePartiesReference
            {
                DocumentIssuerIdref = GetDocumentIssuerIdRef(),
                DocumentRecipientIdrefs = new List<DocumentRecipientIdref>{
                    GetDocumentRecipientIdRef()
                }
            };
            model.Languages.Add(new Language(LanguageCodes.deu, true));
            model.Languages.Add(new Language(LanguageCodes.eng));
            model.MimeInfo = GetMimeInfo();
            model.MimeRoots = new List<MultiLingualString>
            {
                new MultiLingualString("ftp://server/de", LanguageCodes.deu),
                new MultiLingualString("ftp://server/en", LanguageCodes.eng)
            };
            model.OrderDate = DateTime.UtcNow;
            model.ReceiptAcknowledgementId = "ReceiptAcknowledgementId";
            model.Parties = new List<Party>
            {
                GetBuyerParty(),
                GetSupplierParty()
            };
            model.Remarks = new List<Remark>
            {
                new Remark("Handle with care", RemarkTypeValues.Transport),
                new Remark("Ring 4 times", RemarkTypeValues.DeliveryNote)
            };

            return model;
        }

        private Party GetSupplierParty()
        {
            return new Party
            {
                Roles = new List<PartyRole> { PartyRole.Supplier },
                PartyIds = new List<PartyId>
                {
                    (PartyId)GetSupplierIdRef()
                }
            };
        }

        private Party GetBuyerParty()
        {
            return new Party
            {
                Roles = new List<PartyRole> { PartyRole.Buyer },
                PartyIds = new List<PartyId>
                {
                    (PartyId)GetBuyerIdRef()
                }
            };
        }

        private SupplierIdref GetSupplierIdRef()
        {
            return new SupplierIdref("Supplier", PartyTypeValues.SupplierSpecific);
        }

        private BuyerIdref GetBuyerIdRef()
        {
            return new BuyerIdref("Buyer", PartyTypeValues.CustomerSpecific);
        }

        private MimeInfo GetMimeInfo()
        {
            var model = new MimeInfo();

            model.Mimes.Add(GetMime());

            return model;
        }

        private static Mime GetMime()
        {
            return new Mime
            {
                MimeAlternativeTexts = new List<MultiLingualString>
                {
                    new MultiLingualString("Bitte Lesen", LanguageCodes.deu),
                    new MultiLingualString("Readme", LanguageCodes.eng)
                },
                MimeDescriptions = new List<MultiLingualString>
                {
                    new MultiLingualString("Eine Text Datei", LanguageCodes.deu),
                    new MultiLingualString("A text file", LanguageCodes.eng)
                },
                MimePurpose = MimePurpose.Others,
                MimeSources = new List<MultiLingualString>
                {
                    new MultiLingualString("ftp://server/de/", LanguageCodes.deu),
                    new MultiLingualString("ftp://server/en/", LanguageCodes.eng)
                },
                MimeType = "text/plain",
                MimeEmbeddeds = new List<MimeEmbedded>
                {
                    new MimeEmbedded
                    {
                        FileName = "Lies mich.txt",
                        Language = LanguageCodes.deu,
                        FileSize = 33,
                        MimeData = new MimeData("Gut gemacht, Sie haben es gelesen", "text/plain")
                    },
                    new MimeEmbedded
                    {
                        FileName = "Readme.txt",
                        Language = LanguageCodes.eng,
                        FileSize = 22,
                        MimeData = new MimeData("Well done, you read it", "text/plain")
                    }
                }
            };
        }

        private DocumentRecipientIdref GetDocumentRecipientIdRef()
        {
            return new DocumentRecipientIdref("Unit Test Recipient", PartyTypeValues.PartySpecific);
        }

        private DocumentIssuerIdref GetDocumentIssuerIdRef()
        {
            return new DocumentIssuerIdref("Unit Test Issuer", PartyTypeValues.PartySpecific);
        }

        private DeliveryDate GetDeliveryDate()
        {
            var model = new DeliveryDate();

            model.DeliveryStartDate = DateTime.UtcNow.AddDays(2);
            model.DeliveryEndDate = model.DeliveryStartDate.AddDays(3);
            model.Type = DeliveryDateType.Optional;

            return model;
        }

        private SourcingInformation GetSourcingInformation()
        {
            var model = new SourcingInformation();

            model.CatalogReference = GetCatalogReference();

            return model;
        }

        private static CatalogReference GetCatalogReference()
        {
            return new CatalogReference
            {
                CatalogId = "2021-02",
                CatalogNames = new List<MultiLingualString>
                {
                    new MultiLingualString("Test Catalog 2021", LanguageCodes.eng),
                    new MultiLingualString("Test Katalog 2021", LanguageCodes.deu)
                },
                CatalogVersion = new Version(2, 1)
            };
        }

        private ControlInformation GetControlInformation()
        {
            var controlInformation = new ControlInformation();
            controlInformation.GenerationDate = DateTime.UtcNow;
            controlInformation.GeneratorInfo = "Testing";
            controlInformation.StopAutomaticProcessing = "For unit tests only";

            return controlInformation;
        }
    }
}