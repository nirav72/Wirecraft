// <auto-generated />
namespace Wirecraft.Web.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class initial_database_schema : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201207270348108_initial_database_schema"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAN1c227cNhB9L9B/EPTUFqhlJymQBusWyW5cGK3tIOukjwZX4q6JSqIqUYb32/rQT+ovlKJuFC8SdVntJi9BlpcZcubMcIYa+r9//l38+hz41hOME4TDS/vi7Ny2YOhiD4W7Szsl2x9f27/+8u03i/de8Gx9Lse9zMbRmWFyaT8SEr1xnMR9hAFIzgLkxjjBW3Lm4sABHnZenJ//7FxcOJCSsCkty1p8TEOCAsh+0J9LHLowIinwb7AH/aRopz1rRtW6BQFMIuDCS/tPFEM3BpT+n3BztgIE2NZbHwG6kjX0t7YVvXrzKYFrEuNwt44AQcC/30eQ9m+Bn8Bi3W+iV6ZLP3+RLd0BYYgJJYfDQVu3q03Rbb2n2yf7bFlsa5f2hxh7qUv4QXTY73DfaKBNdGAEY7L/CLfF1Cifer2yLac53RHnV7PlqdlaLu3rkLx8YVu3qe+DjQ8rkVGZrgmO4W8whDEg0PsACIExRcK1B9leJOYCq5D+W3KhuqHwsq0r9Ay9P2C4I48VpxvwXLb8RDH2KUQUjHQOiVPILyz/3c4zipFbMV3hlE5U7K2dhgcTN0ZRrvZey6f/Hbn+zETWBARRtQcq+nsUGOziFjyhHQOrQHOLfJjY1kfos97kEUW54ZwVEHwoRlzFOPiI/RqbecfDGqcxkypW9d6DeAdJczkLp4a7iRGssDvEDjY+3shGMLXJlFza7aULl4ZmZ6rUguAYtZaKU6u1VLrpgjIpta2GqvghHyOtp+zSAa3qHwW1dxnzyUA2FWyO5Gbb/KyZk2SncM71HQpBvDfzjj3ZEMqg2lyGpkyL96yxL6WBntUYX8s0ITiA8RCMucXcITjj554k1sZCbYNi8rgC+/5HougzHzHBt/23MP5YZ5xXo03mWBEEjj2aBii9e4n6h3JM7d2FLsm7i/2jvPtdRmOI6THmQ+yumnhoo/NQ4mKaPY0Ma839RDudhGZEadJwykz466K9Jzkm"
                       + "xgyjo817BPIFSsDzYpgkPd3EqwGnald8pzY6Ju+Hekhtc80eyeSEbpXFtS2qhNBYTyBGnjpPMdwTXBMYTJpZT+s7hqYDw1xQO5G/U1C4oWkyE7aocbAV8aFB9RS5UoWWh2qUsCy+U21QjRH9TrE0EDKUPLa9Tq58sKvvrz6FlI2/p16I11Fz+zcw2MC4IHUdgB2d9xn4Kf11LsmqMTjLvsuhF+1DPyMP4mrwi/bBd+QxQ0Ix+KUsk3z3LRJpHCyjhbJNfZrb+tAzFQz1SlHEDe8QTgRDjx0UavGod/w2SbCLGCylO5E8YW5yfB96Vkf2XB/M3PWKdZP6BEU+cikQL+0fpK3oCVfm2EzDRJIXtugx78IV9CGB1luXsEvkJUhc4MmmSyXjNVuok4VxFh8Bf0kNlsQAhUT2yCh0UQT89oUL0/pdJTkVE7FnBTOF0zW262Mc94qJILAu+SwcDlhGeCuuizpAIV4JSlg7KCp0y1EgtA/0x4CtKRATZbfFGL3R1hTAaPYzwE0+cXU6bjl+hdyDhXs9PJz+2J4Z0IOQp139fOjTquaLQWAdh7aCRJFLCdibyeHpQuRBljAcdpI8TBSuyZP6I07a/0juM4BNTIt1+tXeltUKrm6Y50GcNmvvMICJ4KYRiInG9dfpvSCnEcD4FUwOuzy9pHMInVHlI+u//dUma4TP8iGbTVhDIl031ZmqeAxKp6mSBA24WqiwcKyDUBYMq0jkOUfH5FLwKgK1/XQQKW+wJAoF3k2mZ45YSyL30gIZTrc1LenrKTdK84FVhFt3xlhtQNCihNzuHJEjVehR9DjNbZqLoPycrRWAKoExSGHkzRvtXMg8zEQ4YPeKCypZAh0xtWFUze2Bh3CLLPRxtIFUhwqDu0HUSEIT25lEd6IMDPYvB2VGghywfemKXd5/a7hhFHBwi+ecaYsQdHFCpyhbJFDemFZHWtW3cPICwaJh4WgqCRc3IIpQuOMqC4sWa52XFS5/XPcv"
                       + "6wtyGo7bEK14AFecCI7BDgq9lDVd6RWKE5J9E96A7DZz6QXSMJMDvGQlnOOyuspzqJyQ/T+fJNdXVoe+HOsU06/ovoIsVGIfNzlVa2daWWkn8EGs/xayxH4ahJ1Jop5WXp/Ak8lbzCkUBYTNlSD5a0MbjUYBIU+p0WFOj/uwyVPjmmVaC0dQlBSESoiQMoMmwvrgj51900BQKg1ktAxRqJysE3N5CcvLWHcx2wag/nA+krLyAG2kmuSyOiMFqacdVjXjvUNe9dYwadbSw5bZ972GGbOWr9Ib1PHDSJCpa+sYpS6g6afqBMzn7ryE23J6PbXxoKvr3xrwr1p7+Ka6AK7hm+rmnrRWkj1wzV8lpLVhdS88K6rVGJkuMGvm6eRa3XzyUtVeh+rp1BVoDddXtZpTmta2ylI0nlLZZk6Fq0CT5JQ3HxbJOlpVFRpPqWo8LYvIM9wprEKu3GKkjCxDPXeOxGMqS6uLsXhCdevMWpfScHFIxb1Kx4W0e1GkwN2v/KScOB9iW1RET8hj+fA+oRrOwUJz46WPYOZ+ygE3IERbmJB7/BcML22asr8WHgoOeMTnJInnfxEv+VAmi85a457VgXmwkjMIn0DsPoJYqu8f8UZv62NApniiVy7uuwA8fz+6aJ6G9ZBM+DhEl4+e7js3hqaxr9y6iXwhz7eOZVvnox5mUZob9tBEMorej6+GwOHgVnU6T65OwfcOekxlqBKFrYuPqUY5YOmBlB66J+HPj/7c6CCAE18aDTucNdYx6pnREArSy6LBWB8KJ5mS8LJIadWvOr3+1/0WZrCux5EQ38EMj12Gl/TnJS5z1tmrKjrmraPWfEDoEQUPKdH/ysryj1+JPztu9J+o+7myg6GnlekJVp4es9a0KKybubR0zmJS3ZV/X4Yn9ULj+N6HK6ecsRR+ft/Tdjd+eq6nzwuL476omB065n5gslcTxrCZ86WEumRdLowTtdcsta6cjb5sPf+MQHO2DaaKzoP5"
                       + "D7qSVA19FsW01rS3cFEWAouM8kBfU/OuIv5OWV0tkq2P8ZZqeBX5pa70U2JRmKyuVl5F/E5dDqqknJtiWxm9loO67PbwZfa8LutiJ7Nq+sY8vvnkyuhVKz36Jg9SId1Yru4Riepgkyo3TvA5wFBtSsYpfIY/vWL/bn0caIM9itnlr+X0iOX+ci494BO0q0lkf0c3hG7jcK3GXIdbXB7yworKIcId2A0kIPuA9DYmaAtcQrtdmCT8H7V4H2ygdx3epSRKCd0yDDZ+ozAhixXa+LOK/eaaF3fsU24yxRboMlF2PXsXvkuRX//tjivF/Z2GRBaEFLfqmS5Jdru+21eUbnFoSKgQXxU73cMg8imx5C5cgyeoX1u3DJsSW6wQ2MUgSAoa9Xz6k8LPC55/+R8Wlr/i+1kAAA=="; }
        }
    }
}
