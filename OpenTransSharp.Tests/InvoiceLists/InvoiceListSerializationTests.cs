using FluentAssertions;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OpenTransSharp.Tests.InvoiceLists
{
    public class InvoiceListSerializationTests
    {
        private TestConfig testConfig;
        private OpenTransXmlSerializerFactory serializerFactory;
        private XmlSerializer target;

        public InvoiceListSerializationTests()
        {
            testConfig = new TestConfig();
        }

        [SetUp]
        public void Setup()
        {
            var options = new OpenTransOptions();
            options.Serialization.IncludeUdxTypes = new[]
            {
                typeof(CustomData),
                typeof(CustomData2)
            };

            serializerFactory = new OpenTransXmlSerializerFactory(options);

            target = serializerFactory.Create<InvoiceList>();
        }

        [Test]
        public void Can_serialize_InvoiceList()
        {
            var order = testConfig.InvoiceLists.GetInvoiceList();

            Action action = () => target.Serialize(order);
            action.Should().NotThrow();
        }

        [Test]
        public void Can_validate_InvoiceList()
        {
            var order = testConfig.InvoiceLists.GetInvoiceList();

            //var serialized = target.Serialize(order);
            order.IsValid(target).Should().Be(true);
        }

        [Test]
        public void Can_validate_InvoiceList_with_UDX()
        {
            var order = testConfig.InvoiceLists.GetInvoiceListWithUdx();

            var serialized = target.Serialize(order);
            Debug.WriteLine(serialized);
            order.IsValid(target).Should().Be(true);
        }
    }
}