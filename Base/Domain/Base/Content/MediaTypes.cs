// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediaTypes.cs" company="Allors bvba">
//   Copyright 2002-2013 Allors bvba.
//
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
//
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
//
// Allors Applications is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// For more information visit http://www.allors.com/legal
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using System.IO;

    using Allors.Domain;
    using Allors;

    public partial class MediaTypes
    {
        private const string PngName = "image/png";
        private const string JpegName = "image/jpeg";
        private const string GifName = "image/gif";
        private const string BmpName = "image/bmp";
        private const string PdfName = "application/pdf";
        private const string OctetStreamName = "application/octet-stream";

        // File signatures
        // See http://en.wikipedia.org/wiki/List_of_file_signatures and http://www.garykessler.net/library/file_sigs.html
        private static readonly byte[] PngSignature = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };

        private static readonly byte[] Jpeg2000Signature = { 0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20, 0x0D, 0x0A };
        private static readonly byte[] JpegSignature = { 0xFF, 0xD8, 0xFF };
        private static readonly byte[] Gif87ASignature = { 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 };
        private static readonly byte[] Gif89ASignature = { 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 };
        private static readonly byte[] BmpSignature = { 0x42, 0x4D };
        private static readonly byte[] PdfSignature = { 0x25, 0x50, 0x44, 0x46 };

        private Cache<string, MediaType> cache;

        public Cache<string, MediaType> Cache
        {
            get
            {
                return this.cache ?? (this.cache = new Cache<string, MediaType>(this.Session, Meta.Name));
            }
        }

        public MediaType Png
        {
            get
            {
                return this.Cache[PngName];
            }
        }

        public MediaType Jpeg
        {
            get
            {
                return this.Cache[JpegName];
            }
        }

        public MediaType Gif
        {
            get
            {
                return this.Cache[GifName];
            }
        }

        public MediaType Bmp
        {
            get
            {
                return this.Cache[BmpName];
            }
        }

        public MediaType Pdf
        {
            get
            {
                return this.Cache[PdfName];
            }
        }

        public MediaType OctetStream
        {
            get
            {
                return this.Cache[OctetStreamName];
            }
        }

        protected override void BaseSetup(Setup setup)
        {
            base.BaseSetup(setup);

            new MediaTypeBuilder(this.Session).WithName(PngName).WithDefaultFileExtension("png").Build();
            new MediaTypeBuilder(this.Session).WithName(JpegName).WithDefaultFileExtension("jpg").Build();
            new MediaTypeBuilder(this.Session).WithName(GifName).WithDefaultFileExtension("gif").Build();
            new MediaTypeBuilder(this.Session).WithName(BmpName).WithDefaultFileExtension("bmp").Build();
            new MediaTypeBuilder(this.Session).WithName(PdfName).WithDefaultFileExtension("pdf").Build();
            new MediaTypeBuilder(this.Session).WithName(OctetStreamName).Build();
        }

        protected override void BaseSecure(Security config)
        {
            base.BaseSecure(config);

            var full = new[] { Operation.Read, Operation.Write, Operation.Execute };

            config.GrantAdministrator(this.ObjectType, full);
        }

        private static bool Match(byte[] content, byte[] signature)
        {
            if (content.Length > signature.Length)
            {
                for (var i = 0; i < signature.Length; i++)
                {
                    if (content[i] != signature[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        private MediaType BaseInfer(byte[] content)
        {
            if (Match(content, PngSignature))
            {
                return this.Png;
            }

            if (Match(content, Jpeg2000Signature) || Match(content, JpegSignature))
            {
                return this.Jpeg;
            }

            if (Match(content, Gif87ASignature) || Match(content, Gif89ASignature))
            {
                return this.Gif;
            }

            if (Match(content, BmpSignature))
            {
                return this.Bmp;
            }

            if (Match(content, PdfSignature))
            {
                return this.Pdf;
            }

            return null;
        }
    }
}