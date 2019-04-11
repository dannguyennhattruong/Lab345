using Lab345.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab345.Data
{
    public class Database
    {
        public List<Cheese> Cheeses { get; set; }
        public static Database Create()
        {
            var listCheeses = new List<Cheese>();
            listCheeses.Add(new Cheese()
            {
                Name = "El Trigal Manchego",
                Descriptions = "El Trigal Manchego is named for the Spanish region of La Mancha, also home of Don Quixote. The c heese is produced in the La Mancha region from pasteurised sheep 's milk. It has a black gray or buff coloured rind with a crossh atch pattern, the paste colour is stark white when young, become s yellowish as it ages. The fully aged cheese is usually smeared with olive oil and surface mould is removed. The cheese has hol es throughout the paste with a mild, slightly briny, nutty flavo ur. It is sold at various stages of maturity: at the age of 13 w eeks it is described as curado (cured) and, when over three mont hs old it is referred to as viejo (aged). There is a peppery bit e to cheeses that have reached a great age. It is best known of a series of sheep's cheeses and is similar to Zamorano, Cadiz, C alahora or Castelleno.",
                Country = "Spain",
                Photo = "hinh_003.jpg"
            });

            listCheeses.Add(new Cheese()
            {
                Name = "SAINT ALBRAY",
                Descriptions = "Saint Albray is a flowershaped cheese that comes from the Aquitaine region of France. Ma de with pasteurised cow's milk and ripened for 2 weeks, it slice s off skilfully with each halfpound cut looking like a \"petal\". When each petal comes togeth er around a disk, they form a hollow centre similar to a flower. \n\nInvented in 1976, the cheese is alike to Camembert cheese an d shares the same characteristics but is not as strong as Camemb ert. When young, the soft ripened cheese is moist, rich and mell ow, intensifying with age. At its peak, Saint Albray advances to a more robust, hearty flavour very typical of washed rind chees es. It has a very rich aroma and taste which can be further enjo yed by eating the cheese along with its rind. The cheese goes we ll with fruits, nuts and breads. Serve it with a Pinot Noir or C hianti.",
                Year = 1976,
                Country = "France",
                Photo = "hinh_004.jpg"
            });

            listCheeses.Add(new Cheese()
            {
                Name = "ABBAYE DE BELLOC",
                Descriptions = "Abbaye de Belloc is also known a s 'Abbaye NotreDame de Belloc' since it was produced by the Benedictine monks a t the 'Abbaye de Notre Dame de Belloc' in the Pays Basque region of Aquitaine, France. They used sheep milk available in the loc ality and followed a cheese making process that dates back to 30 00 years.\n\nAbbaye de Belloc is a flat wheel shaped traditional , farmhouse, unpasteurised, semihard cheese made from sheep's milk. It has a natural, crusty, br ownish rind with patches of red, orange and yellow. The rind is marked with tiny craters.\n\nThe cheese has a firm, dense, rich and creamy texture. The taste resembles burnt caramel and there is a distinctive lanolin aroma. Ageing process of the cheese ran ges from four to ten months. The younger wheels are made in Dece mber while the older in July. Both types of cheese wheels are se nt to the market in April",
                Country = "France",
                Photo = "hinh_001.jpg"
            });

            listCheeses.Add(new Cheese()
            {
                Name = "BAD AXE",
                Descriptions = "Bad Axe, named after the river t hat was the site of the Bad Axe Battle in 1832, is a semihard cheese made by Hidden Springs Company, Westby, Wisconsin. M ade using pasteurized sheep's milk, the cheese is aged for 60 da ys. To retain its moisture, Bad Axe is dipped in black wax. The white paste is smooth, creamy and tart.",
                Country = "United States",
                Year = 1832,
                Photo = "hinh_002.jpg"
            });


            listCheeses.Add(new Cheese()
            {
                Name = "WABASH CANNONBALL",
                Descriptions = "Wabash Cannonball is a mouldripened, semisoft goat's cheese made by Judy Schad and her husband Larry at C apriole Farmstead Goat Cheeses in Indiana.\n\nTaking its name fr om the famous folk song of southern Indiana, Wabash Cannonball is dusted with ash and left to mature for about three to five wee ks. When it is young, the chevre is thinskinned, white, and slightly wrinkled, but as it starts to ripen , the Geotrichum and Candidum rind becomes more wrinkled allowin g the ash to shine through. The pate becomes denser and finally, at three to five weeks, the cheese is drier and crumbly. Though , it can be enjoyed in all its stages.\n\nWabash Cannonball is a dense sphere with a gentle, creamy, slightly acidic flavour wit h clean citrusy hints. The rind is a fluffy mushroomy snowballlike covering of Penicillium Candidum mould which gives way to a deeply wrinkled surface of Geotrichum Candidum as it matures. A t its optimum age, the cheese is musky, slightly sweet with a mo re delicate flavour.\n\nCannonball is best on a cheeseboard, ser ved with dry white wines such as Sauvignon Blanc or Gruner Veltl iner. It has been Best-of-Show, American Cheese Society 1995.",
                Year = 1995,
                Country = "Indiana",
                Photo = "hinh_005.jpg"
            });

            return new Database()
            {
                Cheeses = listCheeses
            };
        }

    }
}
