using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factoid_Test
{
    public partial class FactoidFrm : Form
    {
        Dictionary<string, string> rs1426654_AA_pos = null;
        Dictionary<string, string> rs1426654_GG_pos = null;

        const int RESULT_PROB_TRUE = 2;
        const int RESULT_TRUE = 1;
        const int RESULT_FALSE = 0;
        const int RESULT_NA = -1;

        public FactoidFrm()
        {
            InitializeComponent();
        }

        private void FactoidFrm_Load(object sender, EventArgs e)
        {
            rs1426654_AA_pos = new Dictionary<string, string>();
            rs1426654_AA_pos.Add("rs6493274", "A");
            rs1426654_AA_pos.Add("rs8040191", "C");
            rs1426654_AA_pos.Add("rs4368110", "C");
            rs1426654_AA_pos.Add("rs281282", "G");
            rs1426654_AA_pos.Add("rs281286", "T");
            rs1426654_AA_pos.Add("rs8034190", "G");
            rs1426654_AA_pos.Add("rs281290", "T");
            rs1426654_AA_pos.Add("rs281292", "A");
            rs1426654_AA_pos.Add("rs1025145", "A");
            rs1426654_AA_pos.Add("rs281297", "TC");
            rs1426654_AA_pos.Add("rs281299", "T");
            rs1426654_AA_pos.Add("rs281300", "A");
            rs1426654_AA_pos.Add("rs3198", "GA");
            rs1426654_AA_pos.Add("rs11070582", "C");
            rs1426654_AA_pos.Add("rs281302", "AG");
            rs1426654_AA_pos.Add("rs281304", "T");
            rs1426654_AA_pos.Add("rs281311", "A");
            rs1426654_AA_pos.Add("rs281316", "A");
            rs1426654_AA_pos.Add("rs11070583", "CA");
            rs1426654_AA_pos.Add("rs281317", "C");
            rs1426654_AA_pos.Add("rs8026226", "G");
            rs1426654_AA_pos.Add("rs403871", "A");
            rs1426654_AA_pos.Add("rs2433019", "G");
            rs1426654_AA_pos.Add("rs2433020", "CT");
            rs1426654_AA_pos.Add("rs281209", "G");
            rs1426654_AA_pos.Add("rs16959423", "C");
            rs1426654_AA_pos.Add("rs281213", "A");
            rs1426654_AA_pos.Add("rs16959430", "A");
            rs1426654_AA_pos.Add("rs281215", "T");
            rs1426654_AA_pos.Add("rs281216", "T");
            rs1426654_AA_pos.Add("rs17311369", "C");
            rs1426654_AA_pos.Add("rs12438904", "T");
            rs1426654_AA_pos.Add("rs281219", "G");
            rs1426654_AA_pos.Add("rs166835", "TC");
            rs1426654_AA_pos.Add("rs281229", "G");
            rs1426654_AA_pos.Add("rs281236", "GA");
            rs1426654_AA_pos.Add("rs4143629", "A");
            rs1426654_AA_pos.Add("rs4775685", "G");
            rs1426654_AA_pos.Add("rs281238", "CT");
            rs1426654_AA_pos.Add("rs16959483", "T");
            rs1426654_AA_pos.Add("rs6493278", "G");
            rs1426654_AA_pos.Add("rs8039398", "TC");
            rs1426654_AA_pos.Add("rs8038491", "C");
            rs1426654_AA_pos.Add("rs406196", "G");
            rs1426654_AA_pos.Add("rs16959499", "T");
            rs1426654_AA_pos.Add("rs16959504", "A");
            rs1426654_AA_pos.Add("rs1559677", "A");
            rs1426654_AA_pos.Add("rs7162110", "G");
            rs1426654_AA_pos.Add("rs16959519", "T");
            rs1426654_AA_pos.Add("rs392572", "G");
            rs1426654_AA_pos.Add("rs1390869", "T");
            rs1426654_AA_pos.Add("rs421853", "A");
            rs1426654_AA_pos.Add("rs10467988", "G");
            rs1426654_AA_pos.Add("rs16959540", "T");
            rs1426654_AA_pos.Add("rs2173093", "G");
            rs1426654_AA_pos.Add("rs281323", "GA");
            rs1426654_AA_pos.Add("rs1390871", "T");
            rs1426654_AA_pos.Add("rs1981919", "G");
            rs1426654_AA_pos.Add("rs16959543", "A");
            rs1426654_AA_pos.Add("rs8034783", "C");
            rs1426654_AA_pos.Add("rs903978", "T");
            rs1426654_AA_pos.Add("rs16959552", "T");
            rs1426654_AA_pos.Add("rs1797225", "A");
            rs1426654_AA_pos.Add("rs281320", "TG");
            rs1426654_AA_pos.Add("rs7167129", "A");
            rs1426654_AA_pos.Add("rs1496908", "A");
            rs1426654_AA_pos.Add("rs16959561", "C");
            rs1426654_AA_pos.Add("rs8031867", "T");
            rs1426654_AA_pos.Add("rs2059475", "A");
            rs1426654_AA_pos.Add("rs1369645", "G");
            rs1426654_AA_pos.Add("rs12439521", "A");
            rs1426654_AA_pos.Add("rs16959595", "A");
            rs1426654_AA_pos.Add("rs16952896", "G");
            rs1426654_AA_pos.Add("rs1618196", "A");
            rs1426654_AA_pos.Add("rs1797222", "G");
            rs1426654_AA_pos.Add("rs7162813", "A");
            rs1426654_AA_pos.Add("rs1435738", "C");
            rs1426654_AA_pos.Add("rs16959631", "G");
            rs1426654_AA_pos.Add("rs1656623", "G");
            rs1426654_AA_pos.Add("rs2304413", "A");
            rs1426654_AA_pos.Add("rs1656624", "G");
            rs1426654_AA_pos.Add("rs1797236", "G");
            rs1426654_AA_pos.Add("rs890153", "TC");
            rs1426654_AA_pos.Add("rs16959666", "T");
            rs1426654_AA_pos.Add("rs16959669", "T");
            rs1426654_AA_pos.Add("rs1623020", "TC");
            rs1426654_AA_pos.Add("rs1435737", "G");
            rs1426654_AA_pos.Add("rs1035703", "A");
            rs1426654_AA_pos.Add("rs7179135", "C");
            rs1426654_AA_pos.Add("rs1656631", "A");
            rs1426654_AA_pos.Add("rs1797227", "AG");
            rs1426654_AA_pos.Add("rs1435749", "AG");
            rs1426654_AA_pos.Add("rs10519129", "CT");
            rs1426654_AA_pos.Add("rs12437563", "G");
            rs1426654_AA_pos.Add("rs12909534", "A");
            rs1426654_AA_pos.Add("rs4774497", "AG");
            rs1426654_AA_pos.Add("rs1865647", "T");
            rs1426654_AA_pos.Add("rs16959700", "T");
            rs1426654_AA_pos.Add("rs4775698", "T");
            rs1426654_AA_pos.Add("rs10519132", "G");
            rs1426654_AA_pos.Add("rs4603502", "T");
            rs1426654_AA_pos.Add("rs12438075", "C");
            rs1426654_AA_pos.Add("rs11633288", "TC");
            rs1426654_AA_pos.Add("rs4270119", "T");
            rs1426654_AA_pos.Add("rs2060509", "GA");
            rs1426654_AA_pos.Add("rs11634974", "GA");
            rs1426654_AA_pos.Add("rs1865648", "G");
            rs1426654_AA_pos.Add("rs7168717", "AG");
            rs1426654_AA_pos.Add("rs1898110", "GT");
            rs1426654_AA_pos.Add("rs2117798", "A");
            rs1426654_AA_pos.Add("rs1898111", "A");
            rs1426654_AA_pos.Add("rs1898112", "G");
            rs1426654_AA_pos.Add("rs16959768", "A");
            rs1426654_AA_pos.Add("rs1435755", "A");
            rs1426654_AA_pos.Add("rs999128", "T");
            rs1426654_AA_pos.Add("rs999130", "C");
            rs1426654_AA_pos.Add("rs1224671", "G");
            rs1426654_AA_pos.Add("rs1369643", "CT");
            rs1426654_AA_pos.Add("rs1369642", "T");
            rs1426654_AA_pos.Add("rs12914000", "T");
            rs1426654_AA_pos.Add("rs1561042", "G");
            rs1426654_AA_pos.Add("rs16959883", "C");
            rs1426654_AA_pos.Add("rs2573564", "C");
            rs1426654_AA_pos.Add("rs2136897", "T");
            rs1426654_AA_pos.Add("rs12898202", "A");
            rs1426654_AA_pos.Add("rs1347473", "T");
            rs1426654_AA_pos.Add("rs2573568", "C");
            rs1426654_AA_pos.Add("rs16959893", "A");
            rs1426654_AA_pos.Add("rs10152343", "A");
            rs1426654_AA_pos.Add("rs1435742", "AG");
            rs1426654_AA_pos.Add("rs17326895", "C");
            rs1426654_AA_pos.Add("rs1865649", "C");
            rs1426654_AA_pos.Add("rs10851458", "AG");
            rs1426654_AA_pos.Add("rs1224674", "T");
            rs1426654_AA_pos.Add("rs1369637", "G");
            rs1426654_AA_pos.Add("rs12912380", "C");
            rs1426654_AA_pos.Add("rs1435740", "CT");
            rs1426654_AA_pos.Add("rs10519138", "C");
            rs1426654_AA_pos.Add("rs1912637", "C");
            rs1426654_AA_pos.Add("rs7169110", "CA");
            rs1426654_AA_pos.Add("rs8026338", "G");
            rs1426654_AA_pos.Add("rs17327778", "G");
            rs1426654_AA_pos.Add("rs12438387", "GA");
            rs1426654_AA_pos.Add("rs16959924", "A");
            rs1426654_AA_pos.Add("rs17387110", "GT");
            rs1426654_AA_pos.Add("rs9673061", "G");
            rs1426654_AA_pos.Add("rs12593611", "TG");
            rs1426654_AA_pos.Add("rs1912640", "C");
            rs1426654_AA_pos.Add("rs1912643", "C");
            rs1426654_AA_pos.Add("rs11857760", "G");
            rs1426654_AA_pos.Add("rs4775702", "G");
            rs1426654_AA_pos.Add("rs8032760", "TC");
            rs1426654_AA_pos.Add("rs17328497", "TC");
            rs1426654_AA_pos.Add("rs11070608", "CT");
            rs1426654_AA_pos.Add("rs1224652", "A");
            rs1426654_AA_pos.Add("rs1912629", "G");
            rs1426654_AA_pos.Add("rs1224656", "GT");
            rs1426654_AA_pos.Add("rs1224657", "C");
            rs1426654_AA_pos.Add("rs8040348", "CT");
            rs1426654_AA_pos.Add("rs8024211", "A");
            rs1426654_AA_pos.Add("rs1347891", "G");
            rs1426654_AA_pos.Add("rs938045", "A");
            rs1426654_AA_pos.Add("rs9920036", "G");
            rs1426654_AA_pos.Add("rs586799", "AG");
            rs1426654_AA_pos.Add("rs16959996", "G");
            rs1426654_AA_pos.Add("rs17388803", "A");
            rs1426654_AA_pos.Add("rs16959999", "T");
            rs1426654_AA_pos.Add("rs687566", "C");
            rs1426654_AA_pos.Add("rs1153820", "T");
            rs1426654_AA_pos.Add("rs765", "AG");
            rs1426654_AA_pos.Add("rs76739", "AG");
            rs1426654_AA_pos.Add("rs11070610", "C");
            rs1426654_AA_pos.Add("rs11629796", "A");
            rs1426654_AA_pos.Add("rs11855134", "A");
            rs1426654_AA_pos.Add("rs16960030", "G");
            rs1426654_AA_pos.Add("rs501916", "C");
            rs1426654_AA_pos.Add("rs599111", "G");
            rs1426654_AA_pos.Add("rs3743276", "T");
            rs1426654_AA_pos.Add("rs3743279", "A");
            rs1426654_AA_pos.Add("rs3743281", "C");
            rs1426654_AA_pos.Add("rs631164", "A");
            rs1426654_AA_pos.Add("rs537052", "TC");
            rs1426654_AA_pos.Add("rs532598", "G");
            rs1426654_AA_pos.Add("rs531596", "C");
            rs1426654_AA_pos.Add("rs603569", "G");
            rs1426654_AA_pos.Add("rs8037600", "A");
            rs1426654_AA_pos.Add("rs4775710", "A");
            rs1426654_AA_pos.Add("rs11855337", "T");
            rs1426654_AA_pos.Add("rs568215", "CT");
            rs1426654_AA_pos.Add("rs1045688", "C");
            rs1426654_AA_pos.Add("rs3743286", "A");
            rs1426654_AA_pos.Add("rs11857458", "A");
            rs1426654_AA_pos.Add("rs1025760", "T");
            rs1426654_AA_pos.Add("rs652856", "T");
            rs1426654_AA_pos.Add("rs8039913", "T");
            rs1426654_AA_pos.Add("rs8040118", "T");
            rs1426654_AA_pos.Add("rs634939", "TC");
            rs1426654_AA_pos.Add("rs9806697", "AC");
            rs1426654_AA_pos.Add("rs11855291", "G");
            rs1426654_AA_pos.Add("rs512255", "GA");
            rs1426654_AA_pos.Add("rs11635373", "AG");
            rs1426654_AA_pos.Add("rs4775711", "CT");
            rs1426654_AA_pos.Add("rs1439323", "GA");
            rs1426654_AA_pos.Add("rs684715", "CA");
            rs1426654_AA_pos.Add("rs671434", "G");
            rs1426654_AA_pos.Add("rs4775715", "A");
            rs1426654_AA_pos.Add("rs17332642", "G");
            rs1426654_AA_pos.Add("rs557700", "C");
            rs1426654_AA_pos.Add("rs8024406", "T");
            rs1426654_AA_pos.Add("rs645856", "GT");
            rs1426654_AA_pos.Add("rs642399", "GA");
            rs1426654_AA_pos.Add("rs1439331", "C");
            rs1426654_AA_pos.Add("rs477077", "T");
            rs1426654_AA_pos.Add("rs10519146", "A");
            rs1426654_AA_pos.Add("rs17333526", "T");
            rs1426654_AA_pos.Add("rs616614", "CT");
            rs1426654_AA_pos.Add("rs529702", "GA");
            rs1426654_AA_pos.Add("rs17418632", "A");
            rs1426654_AA_pos.Add("rs10519147", "T");
            rs1426654_AA_pos.Add("rs655145", "AG");
            rs1426654_AA_pos.Add("rs963031", "C");
            rs1426654_AA_pos.Add("rs11070615", "A");
            rs1426654_AA_pos.Add("rs1224635", "T");
            rs1426654_AA_pos.Add("rs649603", "A");
            rs1426654_AA_pos.Add("rs935875", "A");
            rs1426654_AA_pos.Add("rs12901858", "G");
            rs1426654_AA_pos.Add("rs502365", "G");
            rs1426654_AA_pos.Add("rs1224631", "GT");
            rs1426654_AA_pos.Add("rs1453846", "C");
            rs1426654_AA_pos.Add("rs568920", "T");
            rs1426654_AA_pos.Add("rs8029881", "G");
            rs1426654_AA_pos.Add("rs8037500", "C");
            rs1426654_AA_pos.Add("rs6493299", "G");
            rs1426654_AA_pos.Add("rs639085", "T");
            rs1426654_AA_pos.Add("rs785016", "CT");
            rs1426654_AA_pos.Add("rs671291", "A");
            rs1426654_AA_pos.Add("rs1542043", "AG");
            rs1426654_AA_pos.Add("rs576606", "CA");
            rs1426654_AA_pos.Add("rs10519150", "G");
            rs1426654_AA_pos.Add("rs1453862", "TC");
            rs1426654_AA_pos.Add("rs10775136", "GA");
            rs1426654_AA_pos.Add("rs12917114", "C");
            rs1426654_AA_pos.Add("rs11070617", "TC");
            rs1426654_AA_pos.Add("rs1224606", "T");
            rs1426654_AA_pos.Add("rs660088", "A");
            rs1426654_AA_pos.Add("rs518949", "TC");
            rs1426654_AA_pos.Add("rs12324326", "C");
            rs1426654_AA_pos.Add("rs633868", "AG");
            rs1426654_AA_pos.Add("rs669653", "G");
            rs1426654_AA_pos.Add("rs16960247", "T");
            rs1426654_AA_pos.Add("rs558454", "T");
            rs1426654_AA_pos.Add("rs785011", "A");
            rs1426654_AA_pos.Add("rs667084", "C");
            rs1426654_AA_pos.Add("rs634820", "A");
            rs1426654_AA_pos.Add("rs677963", "A");
            rs1426654_AA_pos.Add("rs677982", "A");
            rs1426654_AA_pos.Add("rs7162001", "T");
            rs1426654_AA_pos.Add("rs590404", "G");
            rs1426654_AA_pos.Add("rs470888", "G");
            rs1426654_AA_pos.Add("rs618699", "G");
            rs1426654_AA_pos.Add("rs482624", "C");
            rs1426654_AA_pos.Add("rs529245", "G");
            rs1426654_AA_pos.Add("rs498976", "T");
            rs1426654_AA_pos.Add("rs491115", "C");
            rs1426654_AA_pos.Add("rs470754", "T");
            rs1426654_AA_pos.Add("rs530219", "T");
            rs1426654_AA_pos.Add("rs10220730", "T");
            rs1426654_AA_pos.Add("rs16960326", "A");
            rs1426654_AA_pos.Add("rs1377676", "G");
            rs1426654_AA_pos.Add("rs11857820", "A");
            rs1426654_AA_pos.Add("rs509141", "C");
            rs1426654_AA_pos.Add("rs549368", "C");
            rs1426654_AA_pos.Add("rs11853654", "G");
            rs1426654_AA_pos.Add("rs682567", "G");
            rs1426654_AA_pos.Add("rs16960343", "G");
            rs1426654_AA_pos.Add("rs2965306", "G");
            rs1426654_AA_pos.Add("rs12441840", "T");
            rs1426654_AA_pos.Add("rs1106926", "C");
            rs1426654_AA_pos.Add("rs16960355", "G");
            rs1426654_AA_pos.Add("rs12440824", "A");
            rs1426654_AA_pos.Add("rs1453854", "T");
            rs1426654_AA_pos.Add("rs2100425", "G");
            rs1426654_AA_pos.Add("rs751467", "G");
            rs1426654_AA_pos.Add("rs1377678", "T");
            rs1426654_AA_pos.Add("rs2924572", "A");
            rs1426654_AA_pos.Add("rs2965315", "A");
            rs1426654_AA_pos.Add("rs2934190", "C");
            rs1426654_AA_pos.Add("rs4284577", "A");
            rs1426654_AA_pos.Add("rs2934193", "C");
            rs1426654_AA_pos.Add("rs2965317", "T");
            rs1426654_AA_pos.Add("rs2965318", "G");
            rs1426654_AA_pos.Add("rs1453850", "G");
            rs1426654_AA_pos.Add("rs2924567", "G");
            rs1426654_AA_pos.Add("rs2924566", "A");
            rs1426654_AA_pos.Add("rs8033729", "A");
            rs1426654_AA_pos.Add("rs2965321", "G");
            rs1426654_AA_pos.Add("rs16960434", "G");
            rs1426654_AA_pos.Add("rs4775727", "A");
            rs1426654_AA_pos.Add("rs16960451", "C");
            rs1426654_AA_pos.Add("rs1869454", "C");
            rs1426654_AA_pos.Add("rs1869455", "G");
            rs1426654_AA_pos.Add("rs7169979", "G");
            rs1426654_AA_pos.Add("rs2924578", "G");
            rs1426654_AA_pos.Add("rs1377680", "T");
            rs1426654_AA_pos.Add("rs16960482", "C");
            rs1426654_AA_pos.Add("rs4775730", "T");
            rs1426654_AA_pos.Add("rs17423970", "GA");
            rs1426654_AA_pos.Add("rs7164700", "G");
            rs1426654_AA_pos.Add("rs9788731", "C");
            rs1426654_AA_pos.Add("rs9788730", "A");
            rs1426654_AA_pos.Add("rs16960508", "C");
            rs1426654_AA_pos.Add("rs1869453", "AG");
            rs1426654_AA_pos.Add("rs1453857", "CT");
            rs1426654_AA_pos.Add("rs930016", "TG");
            rs1426654_AA_pos.Add("rs2469594", "T");
            rs1426654_AA_pos.Add("rs2470104", "C");
            rs1426654_AA_pos.Add("rs1025199", "AC");
            rs1426654_AA_pos.Add("rs1365453", "A");
            rs1426654_AA_pos.Add("rs991877", "T");
            rs1426654_AA_pos.Add("rs2433363", "GA");
            rs1426654_AA_pos.Add("rs16960541", "G");
            rs1426654_AA_pos.Add("rs10519163", "C");
            rs1426654_AA_pos.Add("rs7178488", "A");
            rs1426654_AA_pos.Add("rs7180657", "T");
            rs1426654_AA_pos.Add("rs2459383", "G");
            rs1426654_AA_pos.Add("rs2250072", "A");
            rs1426654_AA_pos.Add("rs2459385", "A");
            rs1426654_AA_pos.Add("rs12440301", "G");
            rs1426654_AA_pos.Add("rs16960578", "T");
            rs1426654_AA_pos.Add("rs1834640", "A");
            rs1426654_AA_pos.Add("rs2254187", "T");
            rs1426654_AA_pos.Add("rs1559857", "G");
            rs1426654_AA_pos.Add("rs2555362", "C");
            rs1426654_AA_pos.Add("rs2469592", "A");
            rs1426654_AA_pos.Add("rs2470101", "T");
            rs1426654_AA_pos.Add("rs938505", "C");
            rs1426654_AA_pos.Add("rs7359271", "G");
            rs1426654_AA_pos.Add("rs2675346", "C");
            rs1426654_AA_pos.Add("rs7359278", "G");
            rs1426654_AA_pos.Add("rs2433354", "C");
            rs1426654_AA_pos.Add("rs2459391", "A");
            rs1426654_AA_pos.Add("rs2433355", "T");
            rs1426654_AA_pos.Add("rs28675264", "T");
            rs1426654_AA_pos.Add("rs2433356", "G");
            rs1426654_AA_pos.Add("rs16960620", "A");
            rs1426654_AA_pos.Add("rs1365455", "A");
            rs1426654_AA_pos.Add("rs28368656", "C");
            rs1426654_AA_pos.Add("rs2675347", "A");
            rs1426654_AA_pos.Add("rs2555364", "G");
            rs1426654_AA_pos.Add("rs10083691", "T");
            rs1426654_AA_pos.Add("rs2469595", "T");
            rs1426654_AA_pos.Add("rs2675348", "A");
            rs1426654_AA_pos.Add("rs4775737", "G");
            rs1426654_AA_pos.Add("rs955940", "A");
            rs1426654_AA_pos.Add("rs28665442", "C");
            rs1426654_AA_pos.Add("rs938506", "T");
            rs1426654_AA_pos.Add("rs17426596", "T");
            rs1426654_AA_pos.Add("rs2459393", "T");
            rs1426654_AA_pos.Add("rs8040016", "C");
            rs1426654_AA_pos.Add("rs8041528", "T");
            rs1426654_AA_pos.Add("rs16960624", "G");
            rs1426654_AA_pos.Add("rs8041370", "G");
            rs1426654_AA_pos.Add("rs1426654", "A");
            rs1426654_AA_pos.Add("rs28652762", "C");
            rs1426654_AA_pos.Add("rs12914102", "G");
            rs1426654_AA_pos.Add("rs2433357", "T");
            rs1426654_AA_pos.Add("rs4143849", "G");
            rs1426654_AA_pos.Add("rs1981942", "G");
            rs1426654_AA_pos.Add("rs1878188", "C");
            rs1426654_AA_pos.Add("rs3743288", "T");
            rs1426654_AA_pos.Add("rs9302141", "C");
            rs1426654_AA_pos.Add("rs2470102", "A");
            rs1426654_AA_pos.Add("rs3187661", "A");
            rs1426654_AA_pos.Add("rs16960634", "C");
            rs1426654_AA_pos.Add("rs3736482", "C");
            rs1426654_AA_pos.Add("rs9652449", "G");
            rs1426654_AA_pos.Add("rs2413885", "G");
            rs1426654_AA_pos.Add("rs11070627", "T");
            rs1426654_AA_pos.Add("rs11070628", "C");
            rs1426654_AA_pos.Add("rs2413886", "T");
            rs1426654_AA_pos.Add("rs7176599", "T");
            rs1426654_AA_pos.Add("rs34722053", "C");
            rs1426654_AA_pos.Add("rs12913316", "T");
            rs1426654_AA_pos.Add("rs8037482", "A");
            rs1426654_AA_pos.Add("rs4547282", "C");
            rs1426654_AA_pos.Add("rs938504", "T");
            rs1426654_AA_pos.Add("rs1878186", "T");
            rs1426654_AA_pos.Add("rs2413889", "T");
            rs1426654_AA_pos.Add("rs9920281", "A");
            rs1426654_AA_pos.Add("rs1484552", "G");
            rs1426654_AA_pos.Add("rs16960682", "G");
            rs1426654_AA_pos.Add("rs12907018", "G");
            rs1426654_AA_pos.Add("rs12912107", "A");
            rs1426654_AA_pos.Add("rs1484547", "C");
            rs1426654_AA_pos.Add("i5007245", "G");
            rs1426654_AA_pos.Add("rs3825960", "G");
            rs1426654_AA_pos.Add("rs3784614", "C");
            rs1426654_AA_pos.Add("rs12904216", "G");
            rs1426654_AA_pos.Add("rs16960698", "G");
            rs1426654_AA_pos.Add("rs1843144", "C");
            rs1426654_AA_pos.Add("rs1531916", "A");
            rs1426654_AA_pos.Add("rs2413890", "T");
            rs1426654_AA_pos.Add("rs11070629", "A");
            rs1426654_AA_pos.Add("rs11633336", "G");
            rs1426654_AA_pos.Add("rs6493311", "T");
            rs1426654_AA_pos.Add("rs8034192", "G");
            rs1426654_AA_pos.Add("rs2279366", "G");
            rs1426654_AA_pos.Add("rs2279369", "G");
            rs1426654_AA_pos.Add("rs6493312", "C");
            rs1426654_AA_pos.Add("i5007246", "G");
            rs1426654_AA_pos.Add("i5007247", "G");
            rs1426654_AA_pos.Add("rs8026268", "G");
            rs1426654_AA_pos.Add("rs8032420", "C");
            rs1426654_AA_pos.Add("rs12593807", "T");
            rs1426654_AA_pos.Add("rs2291340", "T");
            rs1426654_AA_pos.Add("rs1385212", "C");
            rs1426654_AA_pos.Add("rs1878187", "A");
            rs1426654_AA_pos.Add("rs1484551", "G");
            rs1426654_AA_pos.Add("rs8040834", "T");
            rs1426654_AA_pos.Add("rs8039702", "C");
            rs1426654_AA_pos.Add("rs6493314", "C");
            rs1426654_AA_pos.Add("rs6493316", "C");
            rs1426654_AA_pos.Add("rs6493317", "T");
            rs1426654_AA_pos.Add("rs6493318", "T");
            rs1426654_AA_pos.Add("rs3784616", "G");
            rs1426654_AA_pos.Add("rs8039653", "A");
            rs1426654_AA_pos.Add("rs8040405", "G");
            rs1426654_AA_pos.Add("rs12594698", "C");
            rs1426654_AA_pos.Add("rs3784617", "A");
            rs1426654_AA_pos.Add("rs7179027", "A");
            rs1426654_AA_pos.Add("rs1552311", "C");
            rs1426654_AA_pos.Add("rs17350938", "A");
            rs1426654_AA_pos.Add("rs10152424", "C");
            rs1426654_AA_pos.Add("rs7174935", "T");
            rs1426654_AA_pos.Add("rs8025278", "T");
            rs1426654_AA_pos.Add("rs964611", "C");
            rs1426654_AA_pos.Add("rs7168752", "T");
            rs1426654_AA_pos.Add("rs2413891", "G");
            rs1426654_AA_pos.Add("rs8032357", "A");
            rs1426654_AA_pos.Add("rs12592155", "C");
            rs1426654_AA_pos.Add("rs3784619", "A");
            rs1426654_AA_pos.Add("rs7175137", "T");
            rs1426654_AA_pos.Add("rs3784621", "T");
            rs1426654_AA_pos.Add("rs11637235", "T");
            rs1426654_AA_pos.Add("rs12441867", "C");
            rs1426654_AA_pos.Add("rs4775748", "T");
            rs1426654_AA_pos.Add("rs12917438", "G");
            rs1426654_AA_pos.Add("rs4775749", "A");
            rs1426654_AA_pos.Add("rs971952", "T");
            rs1426654_AA_pos.Add("rs1872304", "G");
            rs1426654_AA_pos.Add("rs4775754", "T");
            rs1426654_AA_pos.Add("rs10519169", "A");
            rs1426654_AA_pos.Add("rs16960843", "A");
            rs1426654_AA_pos.Add("rs16960846", "T");
            rs1426654_AA_pos.Add("rs4775758", "A");
            rs1426654_AA_pos.Add("rs4238373", "C");
            rs1426654_AA_pos.Add("rs1426721", "A");
            rs1426654_AA_pos.Add("rs959324", "G");
            rs1426654_AA_pos.Add("rs919129", "A");
            rs1426654_AA_pos.Add("rs11854805", "T");
            rs1426654_AA_pos.Add("rs8043050", "T");
            rs1426654_AA_pos.Add("rs12904816", "C");
            rs1426654_AA_pos.Add("rs8025596", "G");
            rs1426654_AA_pos.Add("rs13379681", "A");
            rs1426654_AA_pos.Add("rs1820489", "T");
            rs1426654_AA_pos.Add("rs10519170", "A");
            rs1426654_AA_pos.Add("rs8042740", "C");
            rs1426654_AA_pos.Add("rs8032308", "G");
            rs1426654_AA_pos.Add("rs17352842", "C");
            rs1426654_AA_pos.Add("rs16960886", "G");
            rs1426654_AA_pos.Add("rs2899417", "C");
            rs1426654_AA_pos.Add("rs11070641", "T");
            rs1426654_AA_pos.Add("rs12050562", "C");
            rs1426654_AA_pos.Add("rs3803350", "A");
            rs1426654_AA_pos.Add("rs7177445", "A");
            rs1426654_AA_pos.Add("i5001950", "G");
            rs1426654_AA_pos.Add("i5001962", "C");
            rs1426654_AA_pos.Add("i5001963", "C");
            rs1426654_AA_pos.Add("rs17456936", "G");
            rs1426654_AA_pos.Add("i5001946", "G");
            rs1426654_AA_pos.Add("rs12916536", "G");
            rs1426654_AA_pos.Add("rs2303505", "G");
            rs1426654_AA_pos.Add("rs363838", "T");
            rs1426654_AA_pos.Add("rs1820488", "T");
            rs1426654_AA_pos.Add("rs363811", "C");
            rs1426654_AA_pos.Add("rs1467953", "G");
            rs1426654_AA_pos.Add("i5001952", "C");
            rs1426654_AA_pos.Add("i5001964", "C");
            rs1426654_AA_pos.Add("i5001966", "A");
            rs1426654_AA_pos.Add("rs363830", "C");
            rs1426654_AA_pos.Add("rs363835", "G");
            rs1426654_AA_pos.Add("rs7175546", "T");
            rs1426654_AA_pos.Add("i5001894", "C");
            rs1426654_AA_pos.Add("i5001957", "C");
            rs1426654_AA_pos.Add("i5001958", "A");
            rs1426654_AA_pos.Add("rs363821", "C");
            rs1426654_AA_pos.Add("rs4255736", "A");
            rs1426654_AA_pos.Add("i5001955", "T");
            rs1426654_AA_pos.Add("i5900422", "G");
            rs1426654_AA_pos.Add("rs363815", "A");
            rs1426654_AA_pos.Add("rs363805", "C");
            rs1426654_AA_pos.Add("rs363804", "C");
            rs1426654_AA_pos.Add("rs363803", "A");
            rs1426654_AA_pos.Add("rs363802", "C");
            rs1426654_AA_pos.Add("rs363807", "G");
            rs1426654_AA_pos.Add("rs363806", "G");
            rs1426654_AA_pos.Add("i5001898", "G");
            rs1426654_AA_pos.Add("rs2303500", "G");
            rs1426654_AA_pos.Add("rs7169625", "T");
            rs1426654_AA_pos.Add("rs16960962", "C");
            rs1426654_AA_pos.Add("rs1426715", "G");
            rs1426654_AA_pos.Add("rs2555470", "T");
            rs1426654_AA_pos.Add("rs16960965", "G");
            rs1426654_AA_pos.Add("rs17458021", "G");
            rs1426654_AA_pos.Add("rs140649", "C");
            rs1426654_AA_pos.Add("rs2620361", "T");
            rs1426654_AA_pos.Add("rs140626", "C");
            rs1426654_AA_pos.Add("i5001959", "A");
            rs1426654_AA_pos.Add("rs10519177", "A");
            rs1426654_AA_pos.Add("rs140630", "G");
            rs1426654_AA_pos.Add("rs4774517", "G");
            rs1426654_AA_pos.Add("i5001893", "A");
            rs1426654_AA_pos.Add("i5001892", "C");
            rs1426654_AA_pos.Add("i5001891", "A");
            rs1426654_AA_pos.Add("rs9806323", "T");
            rs1426654_AA_pos.Add("i5001896", "G");
            rs1426654_AA_pos.Add("rs140638", "T");
            rs1426654_AA_pos.Add("i5001895", "T");
            rs1426654_AA_pos.Add("rs11070643", "C");
            rs1426654_AA_pos.Add("rs2413906", "A");
            rs1426654_AA_pos.Add("rs140648", "T");
            rs1426654_AA_pos.Add("rs140647", "T");
            rs1426654_AA_pos.Add("i5001939", "A");
            rs1426654_AA_pos.Add("i5001961", "C");
            rs1426654_AA_pos.Add("i5001960", "A");
            rs1426654_AA_pos.Add("i5001944", "C");
            rs1426654_AA_pos.Add("i5001947", "C");
            rs1426654_AA_pos.Add("i5001887", "C");
            rs1426654_AA_pos.Add("i5001938", "C");
            rs1426654_AA_pos.Add("rs11853943", "C");
            rs1426654_AA_pos.Add("rs140599", "C");
            rs1426654_AA_pos.Add("rs140598", "G");
            rs1426654_AA_pos.Add("rs2228241", "G");
            rs1426654_AA_pos.Add("i5001886", "C");
            rs1426654_AA_pos.Add("i5001948", "C");
            rs1426654_AA_pos.Add("i5001945", "C");
            rs1426654_AA_pos.Add("rs140597", "T");
            rs1426654_AA_pos.Add("rs7176364", "A");
            rs1426654_AA_pos.Add("rs140587", "G");
            rs1426654_AA_pos.Add("i5001888", "C");
            rs1426654_AA_pos.Add("rs140586", "A");
            rs1426654_AA_pos.Add("i5001951", "A");
            rs1426654_AA_pos.Add("i5001883", "C");
            rs1426654_AA_pos.Add("i5001943", "T");
            rs1426654_AA_pos.Add("i5001885", "C");
            rs1426654_AA_pos.Add("rs55831697", "C");
            rs1426654_AA_pos.Add("rs140593", "C");
            rs1426654_AA_pos.Add("rs140592", "A");
            rs1426654_AA_pos.Add("i5001881", "C");
            rs1426654_AA_pos.Add("rs11635140", "T");
            rs1426654_AA_pos.Add("rs7165060", "C");
            rs1426654_AA_pos.Add("rs140583", "G");
            rs1426654_AA_pos.Add("i5900418", "T");
            rs1426654_AA_pos.Add("i5001953", "T");
            rs1426654_AA_pos.Add("rs16961033", "G");
            rs1426654_AA_pos.Add("rs17361868", "C");
            rs1426654_AA_pos.Add("rs8033037", "A");
            rs1426654_AA_pos.Add("rs25457", "T");
            rs1426654_AA_pos.Add("i5001954", "T");
            rs1426654_AA_pos.Add("rs9806163", "T");
            rs1426654_AA_pos.Add("i5001937", "G");
            rs1426654_AA_pos.Add("rs16961065", "C");
            rs1426654_AA_pos.Add("i5001889", "G");
            rs1426654_AA_pos.Add("rs4775765", "T");
            rs1426654_AA_pos.Add("rs6493327", "G");
            rs1426654_AA_pos.Add("rs755251", "A");
            rs1426654_AA_pos.Add("rs12324002", "A");
            rs1426654_AA_pos.Add("rs6493328", "G");
            rs1426654_AA_pos.Add("rs1871484", "T");
            rs1426654_AA_pos.Add("rs5027380", "C");
            rs1426654_AA_pos.Add("rs7164585", "T");
            rs1426654_AA_pos.Add("rs12906911", "A");
            rs1426654_AA_pos.Add("i5001884", "G");
            rs1426654_AA_pos.Add("rs605372", "T");
            rs1426654_AA_pos.Add("rs598029", "A");
            rs1426654_AA_pos.Add("rs17363343", "G");
            rs1426654_AA_pos.Add("rs10444797", "G");
            rs1426654_AA_pos.Add("rs683282", "T");
            rs1426654_AA_pos.Add("rs10519185", "T");
            rs1426654_AA_pos.Add("rs12915677", "C");
            rs1426654_AA_pos.Add("rs7183203", "T");
            rs1426654_AA_pos.Add("rs12591273", "G");
            rs1426654_AA_pos.Add("rs7169848", "T");
            rs1426654_AA_pos.Add("rs16961205", "C");
            rs1426654_AA_pos.Add("rs657635", "A");
            rs1426654_AA_pos.Add("rs1354738", "T");
            rs1426654_AA_pos.Add("rs17364665", "A");
            rs1426654_AA_pos.Add("rs1876207", "G");
            rs1426654_AA_pos.Add("rs363853", "A");
            rs1426654_AA_pos.Add("rs668842", "C");
            rs1426654_AA_pos.Add("i5001949", "G");
            rs1426654_AA_pos.Add("rs1678979", "T");
            rs1426654_AA_pos.Add("rs1876206", "T");
            rs1426654_AA_pos.Add("i5001897", "G");
            rs1426654_AA_pos.Add("rs25403", "G");
            rs1426654_AA_pos.Add("rs16961239", "A");
            rs1426654_AA_pos.Add("rs1807301", "A");
            rs1426654_AA_pos.Add("rs1036477", "A");
            rs1426654_AA_pos.Add("rs1567074", "G");
            rs1426654_AA_pos.Add("rs2118181", "T");
            rs1426654_AA_pos.Add("rs1827918", "T");
            rs1426654_AA_pos.Add("rs1678983", "T");
            rs1426654_AA_pos.Add("rs2247876", "T");
            rs1426654_AA_pos.Add("rs6493331", "C");
            rs1426654_AA_pos.Add("rs7179473", "T");
            rs1426654_AA_pos.Add("rs25398", "C");
            rs1426654_AA_pos.Add("rs6493333", "C");
            rs1426654_AA_pos.Add("rs2289136", "A");
            rs1426654_AA_pos.Add("rs1848053", "A");
            rs1426654_AA_pos.Add("rs2099562", "G");
            rs1426654_AA_pos.Add("rs1961312", "C");
            rs1426654_AA_pos.Add("rs10493625", "G");
            rs1426654_AA_pos.Add("rs16961323", "G");
            rs1426654_AA_pos.Add("rs1566816", "T");
            rs1426654_AA_pos.Add("rs10851470", "A");
            rs1426654_AA_pos.Add("rs2045891", "T");
            rs1426654_AA_pos.Add("rs12910178", "T");
            rs1426654_AA_pos.Add("rs7175415", "T");
            rs1426654_AA_pos.Add("rs2725544", "A");
            rs1426654_AA_pos.Add("rs1072994", "T");
            rs1426654_AA_pos.Add("rs1114254", "C");
            rs1426654_AA_pos.Add("rs17463995", "CT");
            rs1426654_AA_pos.Add("rs2413913", "C");
            rs1426654_AA_pos.Add("rs12594187", "TC");
            rs1426654_AA_pos.Add("rs784414", "C");
            rs1426654_AA_pos.Add("rs784415", "G");
            rs1426654_AA_pos.Add("rs784416", "C");
            rs1426654_AA_pos.Add("rs784417", "A");
            rs1426654_AA_pos.Add("rs804319", "T");
            rs1426654_AA_pos.Add("rs7180856", "T");
            rs1426654_AA_pos.Add("rs809207", "A");
            rs1426654_AA_pos.Add("rs784405", "T");
            rs1426654_AA_pos.Add("rs16961518", "A");
            rs1426654_AA_pos.Add("rs1677249", "T");
            rs1426654_AA_pos.Add("rs12185099", "C");
            rs1426654_AA_pos.Add("rs784411", "T");
            rs1426654_AA_pos.Add("rs16961533", "C");
            rs1426654_AA_pos.Add("rs1677251", "G");
            rs1426654_AA_pos.Add("rs16961587", "A");
            rs1426654_AA_pos.Add("rs2289178", "C");
            rs1426654_AA_pos.Add("rs8041414", "T");
            rs1426654_AA_pos.Add("rs11631110", "CT");
            rs1426654_AA_pos.Add("rs9302144", "C");
            rs1426654_AA_pos.Add("rs16961610", "G");
            rs1426654_AA_pos.Add("rs12440614", "T");
            rs1426654_AA_pos.Add("rs7179618", "C");
            rs1426654_AA_pos.Add("rs11631496", "T");
            rs1426654_AA_pos.Add("rs17465874", "G");
            rs1426654_AA_pos.Add("rs7170604", "A");
            rs1426654_AA_pos.Add("rs2289181", "G");
            rs1426654_AA_pos.Add("rs6493339", "C");
            rs1426654_AA_pos.Add("rs8035205", "A");
            rs1426654_AA_pos.Add("rs4482220", "G");
            rs1426654_AA_pos.Add("rs2899423", "GA");
            rs1426654_AA_pos.Add("rs2304546", "T");
            rs1426654_AA_pos.Add("rs8037097", "CA");
            rs1426654_AA_pos.Add("rs2413914", "T");
            rs1426654_AA_pos.Add("rs4775775", "AG");
            rs1426654_AA_pos.Add("rs11070654", "CT");
            rs1426654_AA_pos.Add("rs2304547", "AG");
            rs1426654_AA_pos.Add("rs1062124", "AG");
            rs1426654_AA_pos.Add("rs3743292", "CT");
            rs1426654_AA_pos.Add("rs1426199", "G");
            rs1426654_AA_pos.Add("rs16961695", "A");
            rs1426654_AA_pos.Add("rs4775777", "AG");
            rs1426654_AA_pos.Add("rs17382306", "G");
            rs1426654_AA_pos.Add("rs2413917", "T");
            rs1426654_AA_pos.Add("rs8040253", "C");
            rs1426654_AA_pos.Add("rs12906456", "C");
            rs1426654_AA_pos.Add("rs16961728", "T");
            rs1426654_AA_pos.Add("rs16961733", "C");
            rs1426654_AA_pos.Add("rs7183535", "G");
            rs1426654_AA_pos.Add("rs1974961", "T");
            rs1426654_AA_pos.Add("rs9672326", "T");
            rs1426654_AA_pos.Add("rs10519192", "G");
            rs1426654_AA_pos.Add("rs10519193", "C");
            rs1426654_AA_pos.Add("rs10519194", "A");
            rs1426654_AA_pos.Add("rs4435197", "T");
            rs1426654_AA_pos.Add("rs9806753", "G");
            rs1426654_AA_pos.Add("rs1426203", "G");
            rs1426654_AA_pos.Add("rs10519197", "T");


            rs1426654_GG_pos = new Dictionary<string, string>();
            rs1426654_GG_pos.Add("rs6493274", "A");
            rs1426654_GG_pos.Add("rs8040191", "C");
            rs1426654_GG_pos.Add("rs4368110", "C");
            rs1426654_GG_pos.Add("rs281282", "GA");
            rs1426654_GG_pos.Add("rs281286", "CT");
            rs1426654_GG_pos.Add("rs8034190", "G");
            rs1426654_GG_pos.Add("rs281290", "T");
            rs1426654_GG_pos.Add("rs281292", "A");
            rs1426654_GG_pos.Add("rs1025145", "A");
            rs1426654_GG_pos.Add("rs281297", "C");
            rs1426654_GG_pos.Add("rs281299", "T");
            rs1426654_GG_pos.Add("rs281300", "A");
            rs1426654_GG_pos.Add("rs3198", "A");
            rs1426654_GG_pos.Add("rs11070582", "C");
            rs1426654_GG_pos.Add("rs281302", "A");
            rs1426654_GG_pos.Add("rs281304", "T");
            rs1426654_GG_pos.Add("rs281311", "A");
            rs1426654_GG_pos.Add("rs281316", "AG");
            rs1426654_GG_pos.Add("rs11070583", "CA");
            rs1426654_GG_pos.Add("rs281317", "C");
            rs1426654_GG_pos.Add("rs8026226", "G");
            rs1426654_GG_pos.Add("rs403871", "A");
            rs1426654_GG_pos.Add("rs2433019", "G");
            rs1426654_GG_pos.Add("rs2433020", "C");
            rs1426654_GG_pos.Add("rs281209", "G");
            rs1426654_GG_pos.Add("rs16959423", "C");
            rs1426654_GG_pos.Add("rs281213", "A");
            rs1426654_GG_pos.Add("rs16959430", "A");
            rs1426654_GG_pos.Add("rs281215", "T");
            rs1426654_GG_pos.Add("rs281216", "T");
            rs1426654_GG_pos.Add("rs17311369", "C");
            rs1426654_GG_pos.Add("rs12438904", "T");
            rs1426654_GG_pos.Add("rs281219", "G");
            rs1426654_GG_pos.Add("rs166835", "T");
            rs1426654_GG_pos.Add("rs281229", "G");
            rs1426654_GG_pos.Add("rs281236", "G");
            rs1426654_GG_pos.Add("rs4143629", "A");
            rs1426654_GG_pos.Add("rs4775685", "G");
            rs1426654_GG_pos.Add("rs281238", "C");
            rs1426654_GG_pos.Add("rs16959483", "T");
            rs1426654_GG_pos.Add("rs6493278", "G");
            rs1426654_GG_pos.Add("rs8039398", "C");
            rs1426654_GG_pos.Add("rs8038491", "C");
            rs1426654_GG_pos.Add("rs406196", "G");
            rs1426654_GG_pos.Add("rs16959499", "T");
            rs1426654_GG_pos.Add("rs16959504", "AG");
            rs1426654_GG_pos.Add("rs1559677", "GA");
            rs1426654_GG_pos.Add("rs7162110", "G");
            rs1426654_GG_pos.Add("rs16959519", "T");
            rs1426654_GG_pos.Add("rs392572", "G");
            rs1426654_GG_pos.Add("rs1390869", "C");
            rs1426654_GG_pos.Add("rs421853", "A");
            rs1426654_GG_pos.Add("rs10467988", "G");
            rs1426654_GG_pos.Add("rs16959540", "T");
            rs1426654_GG_pos.Add("rs2173093", "A");
            rs1426654_GG_pos.Add("rs281323", "A");
            rs1426654_GG_pos.Add("rs1390871", "CT");
            rs1426654_GG_pos.Add("rs1981919", "G");
            rs1426654_GG_pos.Add("rs16959543", "A");
            rs1426654_GG_pos.Add("rs8034783", "C");
            rs1426654_GG_pos.Add("rs16959552", "T");
            rs1426654_GG_pos.Add("rs1797225", "A");
            rs1426654_GG_pos.Add("rs281320", "G");
            rs1426654_GG_pos.Add("rs7167129", "A");
            rs1426654_GG_pos.Add("rs1496908", "A");
            rs1426654_GG_pos.Add("rs16959561", "C");
            rs1426654_GG_pos.Add("rs8031867", "T");
            rs1426654_GG_pos.Add("rs2059475", "A");
            rs1426654_GG_pos.Add("rs1369645", "AG");
            rs1426654_GG_pos.Add("rs12439521", "A");
            rs1426654_GG_pos.Add("rs16959595", "A");
            rs1426654_GG_pos.Add("rs16952896", "GA");
            rs1426654_GG_pos.Add("rs1618196", "G");
            rs1426654_GG_pos.Add("rs1797222", "G");
            rs1426654_GG_pos.Add("rs7162813", "A");
            rs1426654_GG_pos.Add("rs1435738", "C");
            rs1426654_GG_pos.Add("rs16959631", "G");
            rs1426654_GG_pos.Add("rs1656623", "A");
            rs1426654_GG_pos.Add("rs2304413", "A");
            rs1426654_GG_pos.Add("rs1656624", "G");
            rs1426654_GG_pos.Add("rs1797236", "G");
            rs1426654_GG_pos.Add("rs890153", "C");
            rs1426654_GG_pos.Add("rs16959666", "T");
            rs1426654_GG_pos.Add("rs16959669", "T");
            rs1426654_GG_pos.Add("rs1623020", "CT");
            rs1426654_GG_pos.Add("rs1435737", "G");
            rs1426654_GG_pos.Add("rs1035703", "A");
            rs1426654_GG_pos.Add("rs7179135", "C");
            rs1426654_GG_pos.Add("rs1656631", "CA");
            rs1426654_GG_pos.Add("rs1797227", "G");
            rs1426654_GG_pos.Add("rs1435749", "GA");
            rs1426654_GG_pos.Add("rs10519129", "TC");
            rs1426654_GG_pos.Add("rs12437563", "G");
            rs1426654_GG_pos.Add("rs12909534", "A");
            rs1426654_GG_pos.Add("rs4774497", "G");
            rs1426654_GG_pos.Add("rs1865647", "T");
            rs1426654_GG_pos.Add("rs16959700", "T");
            rs1426654_GG_pos.Add("rs4775698", "T");
            rs1426654_GG_pos.Add("rs10519132", "G");
            rs1426654_GG_pos.Add("rs4603502", "T");
            rs1426654_GG_pos.Add("rs12438075", "C");
            rs1426654_GG_pos.Add("rs11633288", "C");
            rs1426654_GG_pos.Add("rs4270119", "T");
            rs1426654_GG_pos.Add("rs2060509", "A");
            rs1426654_GG_pos.Add("rs11634974", "A");
            rs1426654_GG_pos.Add("rs1865648", "G");
            rs1426654_GG_pos.Add("rs7168717", "G");
            rs1426654_GG_pos.Add("rs1898110", "T");
            rs1426654_GG_pos.Add("rs2117798", "A");
            rs1426654_GG_pos.Add("rs1898111", "A");
            rs1426654_GG_pos.Add("rs1898112", "G");
            rs1426654_GG_pos.Add("rs16959768", "A");
            rs1426654_GG_pos.Add("rs1435755", "A");
            rs1426654_GG_pos.Add("rs999128", "T");
            rs1426654_GG_pos.Add("rs999130", "C");
            rs1426654_GG_pos.Add("rs1224671", "G");
            rs1426654_GG_pos.Add("rs1369643", "T");
            rs1426654_GG_pos.Add("rs1369642", "CT");
            rs1426654_GG_pos.Add("rs12914000", "T");
            rs1426654_GG_pos.Add("rs1561042", "AG");
            rs1426654_GG_pos.Add("rs16959883", "C");
            rs1426654_GG_pos.Add("rs2573564", "C");
            rs1426654_GG_pos.Add("rs2136897", "T");
            rs1426654_GG_pos.Add("rs12898202", "AC");
            rs1426654_GG_pos.Add("rs1347473", "T");
            rs1426654_GG_pos.Add("rs2573568", "C");
            rs1426654_GG_pos.Add("rs16959893", "A");
            rs1426654_GG_pos.Add("rs10152343", "A");
            rs1426654_GG_pos.Add("rs1435742", "G");
            rs1426654_GG_pos.Add("rs17326895", "C");
            rs1426654_GG_pos.Add("rs1865649", "C");
            rs1426654_GG_pos.Add("rs10851458", "G");
            rs1426654_GG_pos.Add("rs1224674", "T");
            rs1426654_GG_pos.Add("rs1369637", "G");
            rs1426654_GG_pos.Add("rs12912380", "C");
            rs1426654_GG_pos.Add("rs10519138", "C");
            rs1426654_GG_pos.Add("rs1912637", "C");
            rs1426654_GG_pos.Add("rs7169110", "A");
            rs1426654_GG_pos.Add("rs8026338", "G");
            rs1426654_GG_pos.Add("rs17327778", "G");
            rs1426654_GG_pos.Add("rs12438387", "AG");
            rs1426654_GG_pos.Add("rs16959924", "A");
            rs1426654_GG_pos.Add("rs17387110", "G");
            rs1426654_GG_pos.Add("rs9673061", "G");
            rs1426654_GG_pos.Add("rs12593611", "T");
            rs1426654_GG_pos.Add("rs1912640", "C");
            rs1426654_GG_pos.Add("rs1912643", "C");
            rs1426654_GG_pos.Add("rs11857760", "A");
            rs1426654_GG_pos.Add("rs4775702", "G");
            rs1426654_GG_pos.Add("rs8032760", "T");
            rs1426654_GG_pos.Add("rs17328497", "T");
            rs1426654_GG_pos.Add("rs11070608", "C");
            rs1426654_GG_pos.Add("rs1912629", "G");
            rs1426654_GG_pos.Add("rs1224656", "G");
            rs1426654_GG_pos.Add("rs1224657", "C");
            rs1426654_GG_pos.Add("rs8040348", "C");
            rs1426654_GG_pos.Add("rs8024211", "A");
            rs1426654_GG_pos.Add("rs1347891", "G");
            rs1426654_GG_pos.Add("rs938045", "A");
            rs1426654_GG_pos.Add("rs9920036", "G");
            rs1426654_GG_pos.Add("rs586799", "A");
            rs1426654_GG_pos.Add("rs16959996", "G");
            rs1426654_GG_pos.Add("rs17388803", "A");
            rs1426654_GG_pos.Add("rs16959999", "T");
            rs1426654_GG_pos.Add("rs687566", "CT");
            rs1426654_GG_pos.Add("rs1153820", "T");
            rs1426654_GG_pos.Add("rs765", "G");
            rs1426654_GG_pos.Add("rs76739", "A");
            rs1426654_GG_pos.Add("rs11070610", "C");
            rs1426654_GG_pos.Add("rs11629796", "A");
            rs1426654_GG_pos.Add("rs11855134", "A");
            rs1426654_GG_pos.Add("rs16960030", "G");
            rs1426654_GG_pos.Add("rs501916", "CA");
            rs1426654_GG_pos.Add("rs599111", "GT");
            rs1426654_GG_pos.Add("rs3743276", "CT");
            rs1426654_GG_pos.Add("rs3743279", "A");
            rs1426654_GG_pos.Add("rs3743281", "C");
            rs1426654_GG_pos.Add("rs631164", "A");
            rs1426654_GG_pos.Add("rs537052", "T");
            rs1426654_GG_pos.Add("rs532598", "AG");
            rs1426654_GG_pos.Add("rs531596", "C");
            rs1426654_GG_pos.Add("rs603569", "G");
            rs1426654_GG_pos.Add("rs4775710", "A");
            rs1426654_GG_pos.Add("rs11855337", "T");
            rs1426654_GG_pos.Add("rs568215", "C");
            rs1426654_GG_pos.Add("rs1045688", "C");
            rs1426654_GG_pos.Add("rs3743286", "A");
            rs1426654_GG_pos.Add("rs11857458", "A");
            rs1426654_GG_pos.Add("rs1025760", "T");
            rs1426654_GG_pos.Add("rs652856", "CT");
            rs1426654_GG_pos.Add("rs8039913", "T");
            rs1426654_GG_pos.Add("rs8040118", "T");
            rs1426654_GG_pos.Add("rs634939", "T");
            rs1426654_GG_pos.Add("rs9806697", "C");
            rs1426654_GG_pos.Add("rs11855291", "G");
            rs1426654_GG_pos.Add("rs512255", "G");
            rs1426654_GG_pos.Add("rs11635373", "G");
            rs1426654_GG_pos.Add("rs4775711", "T");
            rs1426654_GG_pos.Add("rs1439323", "A");
            rs1426654_GG_pos.Add("rs684715", "C");
            rs1426654_GG_pos.Add("rs671434", "G");
            rs1426654_GG_pos.Add("rs4775715", "A");
            rs1426654_GG_pos.Add("rs17332642", "G");
            rs1426654_GG_pos.Add("rs557700", "CT");
            rs1426654_GG_pos.Add("rs8024406", "T");
            rs1426654_GG_pos.Add("rs645856", "T");
            rs1426654_GG_pos.Add("rs642399", "G");
            rs1426654_GG_pos.Add("rs1439331", "C");
            rs1426654_GG_pos.Add("rs477077", "TC");
            rs1426654_GG_pos.Add("rs10519146", "A");
            rs1426654_GG_pos.Add("rs17333526", "T");
            rs1426654_GG_pos.Add("rs616614", "C");
            rs1426654_GG_pos.Add("rs529702", "G");
            rs1426654_GG_pos.Add("rs17418632", "A");
            rs1426654_GG_pos.Add("rs655145", "A");
            rs1426654_GG_pos.Add("rs963031", "C");
            rs1426654_GG_pos.Add("rs11070615", "A");
            rs1426654_GG_pos.Add("rs1224635", "T");
            rs1426654_GG_pos.Add("rs649603", "A");
            rs1426654_GG_pos.Add("rs935875", "A");
            rs1426654_GG_pos.Add("rs12901858", "G");
            rs1426654_GG_pos.Add("rs502365", "G");
            rs1426654_GG_pos.Add("rs1224631", "GT");
            rs1426654_GG_pos.Add("rs1453846", "C");
            rs1426654_GG_pos.Add("rs568920", "T");
            rs1426654_GG_pos.Add("rs8029881", "G");
            rs1426654_GG_pos.Add("rs8037500", "C");
            rs1426654_GG_pos.Add("rs6493299", "G");
            rs1426654_GG_pos.Add("rs639085", "T");
            rs1426654_GG_pos.Add("rs785016", "T");
            rs1426654_GG_pos.Add("rs671291", "G");
            rs1426654_GG_pos.Add("rs1542043", "A");
            rs1426654_GG_pos.Add("rs10519150", "G");
            rs1426654_GG_pos.Add("rs1453862", "T");
            rs1426654_GG_pos.Add("rs10775136", "G");
            rs1426654_GG_pos.Add("rs12917114", "C");
            rs1426654_GG_pos.Add("rs11070617", "T");
            rs1426654_GG_pos.Add("rs1224606", "T");
            rs1426654_GG_pos.Add("rs660088", "A");
            rs1426654_GG_pos.Add("rs518949", "T");
            rs1426654_GG_pos.Add("rs12324326", "C");
            rs1426654_GG_pos.Add("rs633868", "GA");
            rs1426654_GG_pos.Add("rs669653", "G");
            rs1426654_GG_pos.Add("rs16960247", "T");
            rs1426654_GG_pos.Add("rs558454", "T");
            rs1426654_GG_pos.Add("rs785011", "A");
            rs1426654_GG_pos.Add("rs667084", "C");
            rs1426654_GG_pos.Add("rs634820", "A");
            rs1426654_GG_pos.Add("rs677963", "A");
            rs1426654_GG_pos.Add("rs677982", "A");
            rs1426654_GG_pos.Add("rs7162001", "T");
            rs1426654_GG_pos.Add("rs590404", "G");
            rs1426654_GG_pos.Add("rs470888", "G");
            rs1426654_GG_pos.Add("rs618699", "G");
            rs1426654_GG_pos.Add("rs482624", "C");
            rs1426654_GG_pos.Add("rs529245", "GA");
            rs1426654_GG_pos.Add("rs498976", "T");
            rs1426654_GG_pos.Add("rs491115", "CT");
            rs1426654_GG_pos.Add("rs470754", "T");
            rs1426654_GG_pos.Add("rs530219", "TC");
            rs1426654_GG_pos.Add("rs10220730", "T");
            rs1426654_GG_pos.Add("rs16960326", "A");
            rs1426654_GG_pos.Add("rs1377676", "G");
            rs1426654_GG_pos.Add("rs11857820", "A");
            rs1426654_GG_pos.Add("rs509141", "C");
            rs1426654_GG_pos.Add("rs549368", "C");
            rs1426654_GG_pos.Add("rs11853654", "G");
            rs1426654_GG_pos.Add("rs682567", "G");
            rs1426654_GG_pos.Add("rs16960343", "G");
            rs1426654_GG_pos.Add("rs2965306", "A");
            rs1426654_GG_pos.Add("rs12441840", "TC");
            rs1426654_GG_pos.Add("rs1106926", "A");
            rs1426654_GG_pos.Add("rs16960355", "G");
            rs1426654_GG_pos.Add("rs12440824", "AG");
            rs1426654_GG_pos.Add("rs1453854", "T");
            rs1426654_GG_pos.Add("rs2100425", "G");
            rs1426654_GG_pos.Add("rs751467", "G");
            rs1426654_GG_pos.Add("rs1377678", "T");
            rs1426654_GG_pos.Add("rs2924572", "A");
            rs1426654_GG_pos.Add("rs2965315", "AG");
            rs1426654_GG_pos.Add("rs2934190", "C");
            rs1426654_GG_pos.Add("rs4284577", "AG");
            rs1426654_GG_pos.Add("rs2934193", "T");
            rs1426654_GG_pos.Add("rs2965317", "TC");
            rs1426654_GG_pos.Add("rs2965318", "GT");
            rs1426654_GG_pos.Add("rs1453850", "GA");
            rs1426654_GG_pos.Add("rs2924567", "G");
            rs1426654_GG_pos.Add("rs2924566", "G");
            rs1426654_GG_pos.Add("rs8033729", "GA");
            rs1426654_GG_pos.Add("rs2965321", "A");
            rs1426654_GG_pos.Add("rs16960434", "G");
            rs1426654_GG_pos.Add("rs4775727", "A");
            rs1426654_GG_pos.Add("rs16960451", "C");
            rs1426654_GG_pos.Add("rs1869454", "C");
            rs1426654_GG_pos.Add("rs1869455", "GA");
            rs1426654_GG_pos.Add("rs7169979", "AG");
            rs1426654_GG_pos.Add("rs2924578", "A");
            rs1426654_GG_pos.Add("rs1377680", "C");
            rs1426654_GG_pos.Add("rs16960482", "CT");
            rs1426654_GG_pos.Add("rs4775730", "C");
            rs1426654_GG_pos.Add("rs17423970", "G");
            rs1426654_GG_pos.Add("rs7164700", "G");
            rs1426654_GG_pos.Add("rs9788731", "CT");
            rs1426654_GG_pos.Add("rs9788730", "C");
            rs1426654_GG_pos.Add("rs16960508", "C");
            rs1426654_GG_pos.Add("rs1869453", "GA");
            rs1426654_GG_pos.Add("rs1453857", "CT");
            rs1426654_GG_pos.Add("rs930016", "T");
            rs1426654_GG_pos.Add("rs2469594", "T");
            rs1426654_GG_pos.Add("rs2470104", "C");
            rs1426654_GG_pos.Add("rs1025199", "AC");
            rs1426654_GG_pos.Add("rs1365453", "A");
            rs1426654_GG_pos.Add("rs991877", "T");
            rs1426654_GG_pos.Add("rs2433363", "G");
            rs1426654_GG_pos.Add("rs16960541", "G");
            rs1426654_GG_pos.Add("rs10519163", "C");
            rs1426654_GG_pos.Add("rs7178488", "GA");
            rs1426654_GG_pos.Add("rs7180657", "T");
            rs1426654_GG_pos.Add("rs2459383", "G");
            rs1426654_GG_pos.Add("rs2250072", "G");
            rs1426654_GG_pos.Add("rs2459385", "CA");
            rs1426654_GG_pos.Add("rs12440301", "A");
            rs1426654_GG_pos.Add("rs16960578", "T");
            rs1426654_GG_pos.Add("rs1834640", "G");
            rs1426654_GG_pos.Add("rs2254187", "T");
            rs1426654_GG_pos.Add("rs1559857", "AG");
            rs1426654_GG_pos.Add("rs2555362", "C");
            rs1426654_GG_pos.Add("rs2469592", "A");
            rs1426654_GG_pos.Add("rs2470101", "T");
            rs1426654_GG_pos.Add("rs938505", "CT");
            rs1426654_GG_pos.Add("rs7359278", "G");
            rs1426654_GG_pos.Add("rs2433354", "T");
            rs1426654_GG_pos.Add("rs2433356", "G");
            rs1426654_GG_pos.Add("rs16960620", "A");
            rs1426654_GG_pos.Add("rs2675347", "GA");
            rs1426654_GG_pos.Add("rs2555364", "CG");
            rs1426654_GG_pos.Add("rs2675348", "G");
            rs1426654_GG_pos.Add("rs4775737", "G");
            rs1426654_GG_pos.Add("rs8040016", "C");
            rs1426654_GG_pos.Add("rs16960624", "G");
            rs1426654_GG_pos.Add("rs1426654", "G");
            rs1426654_GG_pos.Add("rs3743288", "T");
            rs1426654_GG_pos.Add("rs2470102", "G");
            rs1426654_GG_pos.Add("rs16960634", "C");
            rs1426654_GG_pos.Add("rs3736482", "C");
            rs1426654_GG_pos.Add("rs9652449", "G");
            rs1426654_GG_pos.Add("rs2413885", "G");
            rs1426654_GG_pos.Add("rs11070627", "TA");
            rs1426654_GG_pos.Add("rs11070628", "CT");
            rs1426654_GG_pos.Add("rs2413886", "T");
            rs1426654_GG_pos.Add("rs7176599", "CT");
            rs1426654_GG_pos.Add("rs34722053", "C");
            rs1426654_GG_pos.Add("rs12913316", "TC");
            rs1426654_GG_pos.Add("rs8037482", "AG");
            rs1426654_GG_pos.Add("rs4547282", "C");
            rs1426654_GG_pos.Add("rs938504", "T");
            rs1426654_GG_pos.Add("rs1878186", "TC");
            rs1426654_GG_pos.Add("rs2413889", "T");
            rs1426654_GG_pos.Add("rs9920281", "G");
            rs1426654_GG_pos.Add("rs1484552", "G");
            rs1426654_GG_pos.Add("rs16960682", "G");
            rs1426654_GG_pos.Add("rs12907018", "A");
            rs1426654_GG_pos.Add("rs12912107", "G");
            rs1426654_GG_pos.Add("rs1484547", "C");
            rs1426654_GG_pos.Add("i5007245", "G");
            rs1426654_GG_pos.Add("rs3825960", "G");
            rs1426654_GG_pos.Add("rs3784614", "C");
            rs1426654_GG_pos.Add("rs12904216", "A");
            rs1426654_GG_pos.Add("rs16960698", "G");
            rs1426654_GG_pos.Add("rs1843144", "C");
            rs1426654_GG_pos.Add("rs1531916", "AG");
            rs1426654_GG_pos.Add("rs2413890", "G");
            rs1426654_GG_pos.Add("rs11070629", "G");
            rs1426654_GG_pos.Add("rs11633336", "A");
            rs1426654_GG_pos.Add("rs6493311", "CT");
            rs1426654_GG_pos.Add("rs8034192", "GA");
            rs1426654_GG_pos.Add("rs2279366", "G");
            rs1426654_GG_pos.Add("rs2279369", "G");
            rs1426654_GG_pos.Add("rs6493312", "C");
            rs1426654_GG_pos.Add("i5007246", "G");
            rs1426654_GG_pos.Add("i5007247", "G");
            rs1426654_GG_pos.Add("rs8026268", "G");
            rs1426654_GG_pos.Add("rs8032420", "AC");
            rs1426654_GG_pos.Add("rs12593807", "CT");
            rs1426654_GG_pos.Add("rs2291340", "CT");
            rs1426654_GG_pos.Add("rs1385212", "C");
            rs1426654_GG_pos.Add("rs1878187", "A");
            rs1426654_GG_pos.Add("rs1484551", "G");
            rs1426654_GG_pos.Add("rs8040834", "T");
            rs1426654_GG_pos.Add("rs8039702", "CT");
            rs1426654_GG_pos.Add("rs6493314", "C");
            rs1426654_GG_pos.Add("rs6493316", "C");
            rs1426654_GG_pos.Add("rs6493317", "T");
            rs1426654_GG_pos.Add("rs6493318", "T");
            rs1426654_GG_pos.Add("rs3784616", "G");
            rs1426654_GG_pos.Add("rs8039653", "A");
            rs1426654_GG_pos.Add("rs8040405", "G");
            rs1426654_GG_pos.Add("rs12594698", "C");
            rs1426654_GG_pos.Add("rs3784617", "A");
            rs1426654_GG_pos.Add("rs7179027", "A");
            rs1426654_GG_pos.Add("rs1552311", "C");
            rs1426654_GG_pos.Add("rs17350938", "A");
            rs1426654_GG_pos.Add("rs10152424", "CA");
            rs1426654_GG_pos.Add("rs7174935", "T");
            rs1426654_GG_pos.Add("rs8025278", "T");
            rs1426654_GG_pos.Add("rs964611", "C");
            rs1426654_GG_pos.Add("rs7168752", "T");
            rs1426654_GG_pos.Add("rs8032357", "A");
            rs1426654_GG_pos.Add("rs12592155", "C");
            rs1426654_GG_pos.Add("rs7175137", "T");
            rs1426654_GG_pos.Add("rs3784621", "T");
            rs1426654_GG_pos.Add("rs11637235", "C");
            rs1426654_GG_pos.Add("rs12441867", "C");
            rs1426654_GG_pos.Add("rs4775748", "T");
            rs1426654_GG_pos.Add("rs12917438", "G");
            rs1426654_GG_pos.Add("rs4775749", "A");
            rs1426654_GG_pos.Add("rs971952", "T");
            rs1426654_GG_pos.Add("rs1872304", "G");
            rs1426654_GG_pos.Add("rs4775754", "TC");
            rs1426654_GG_pos.Add("rs10519169", "GA");
            rs1426654_GG_pos.Add("rs16960843", "A");
            rs1426654_GG_pos.Add("rs16960846", "T");
            rs1426654_GG_pos.Add("rs4775758", "A");
            rs1426654_GG_pos.Add("rs1426721", "A");
            rs1426654_GG_pos.Add("rs959324", "G");
            rs1426654_GG_pos.Add("rs919129", "A");
            rs1426654_GG_pos.Add("rs11854805", "T");
            rs1426654_GG_pos.Add("rs8043050", "T");
            rs1426654_GG_pos.Add("rs8025596", "G");
            rs1426654_GG_pos.Add("rs1820489", "C");
            rs1426654_GG_pos.Add("rs10519170", "GA");
            rs1426654_GG_pos.Add("rs8042740", "CT");
            rs1426654_GG_pos.Add("rs8032308", "G");
            rs1426654_GG_pos.Add("rs17352842", "C");
            rs1426654_GG_pos.Add("rs16960886", "G");
            rs1426654_GG_pos.Add("rs2899417", "C");
            rs1426654_GG_pos.Add("rs11070641", "T");
            rs1426654_GG_pos.Add("rs12050562", "C");
            rs1426654_GG_pos.Add("rs3803350", "A");
            rs1426654_GG_pos.Add("rs7177445", "A");
            rs1426654_GG_pos.Add("i5001950", "G");
            rs1426654_GG_pos.Add("i5001962", "C");
            rs1426654_GG_pos.Add("i5001963", "C");
            rs1426654_GG_pos.Add("i5001946", "G");
            rs1426654_GG_pos.Add("rs2303505", "G");
            rs1426654_GG_pos.Add("rs363838", "T");
            rs1426654_GG_pos.Add("rs1820488", "T");
            rs1426654_GG_pos.Add("rs363811", "C");
            rs1426654_GG_pos.Add("rs1467953", "G");
            rs1426654_GG_pos.Add("i5001952", "C");
            rs1426654_GG_pos.Add("i5001964", "C");
            rs1426654_GG_pos.Add("i5001966", "A");
            rs1426654_GG_pos.Add("rs363830", "C");
            rs1426654_GG_pos.Add("rs363835", "G");
            rs1426654_GG_pos.Add("rs7175546", "T");
            rs1426654_GG_pos.Add("i5001894", "C");
            rs1426654_GG_pos.Add("i5001957", "C");
            rs1426654_GG_pos.Add("i5001958", "A");
            rs1426654_GG_pos.Add("rs363821", "C");
            rs1426654_GG_pos.Add("rs4255736", "A");
            rs1426654_GG_pos.Add("i5001955", "T");
            rs1426654_GG_pos.Add("i5900422", "G");
            rs1426654_GG_pos.Add("rs363815", "A");
            rs1426654_GG_pos.Add("rs363805", "C");
            rs1426654_GG_pos.Add("rs363804", "C");
            rs1426654_GG_pos.Add("rs363803", "A");
            rs1426654_GG_pos.Add("rs363802", "C");
            rs1426654_GG_pos.Add("rs363807", "G");
            rs1426654_GG_pos.Add("rs363806", "G");
            rs1426654_GG_pos.Add("i5001898", "G");
            rs1426654_GG_pos.Add("rs2303500", "G");
            rs1426654_GG_pos.Add("rs7169625", "T");
            rs1426654_GG_pos.Add("rs1426715", "G");
            rs1426654_GG_pos.Add("rs2555470", "T");
            rs1426654_GG_pos.Add("rs16960965", "G");
            rs1426654_GG_pos.Add("rs17458021", "G");
            rs1426654_GG_pos.Add("rs140649", "C");
            rs1426654_GG_pos.Add("rs2620361", "TG");
            rs1426654_GG_pos.Add("rs140626", "C");
            rs1426654_GG_pos.Add("i5001959", "A");
            rs1426654_GG_pos.Add("rs10519177", "AG");
            rs1426654_GG_pos.Add("rs140630", "G");
            rs1426654_GG_pos.Add("rs4774517", "GT");
            rs1426654_GG_pos.Add("i5001893", "A");
            rs1426654_GG_pos.Add("i5001892", "C");
            rs1426654_GG_pos.Add("i5001891", "A");
            rs1426654_GG_pos.Add("i5001896", "G");
            rs1426654_GG_pos.Add("rs140638", "T");
            rs1426654_GG_pos.Add("i5001895", "T");
            rs1426654_GG_pos.Add("rs11070643", "C");
            rs1426654_GG_pos.Add("rs2413906", "A");
            rs1426654_GG_pos.Add("rs140648", "T");
            rs1426654_GG_pos.Add("rs140647", "T");
            rs1426654_GG_pos.Add("i5001939", "A");
            rs1426654_GG_pos.Add("i5001961", "C");
            rs1426654_GG_pos.Add("i5001960", "A");
            rs1426654_GG_pos.Add("i5001944", "C");
            rs1426654_GG_pos.Add("i5001947", "C");
            rs1426654_GG_pos.Add("i5001887", "C");
            rs1426654_GG_pos.Add("i5001938", "C");
            rs1426654_GG_pos.Add("rs11853943", "C");
            rs1426654_GG_pos.Add("rs140599", "C");
            rs1426654_GG_pos.Add("rs140598", "G");
            rs1426654_GG_pos.Add("rs2228241", "G");
            rs1426654_GG_pos.Add("i5001886", "C");
            rs1426654_GG_pos.Add("i5001948", "C");
            rs1426654_GG_pos.Add("i5001945", "C");
            rs1426654_GG_pos.Add("rs140597", "T");
            rs1426654_GG_pos.Add("rs7176364", "A");
            rs1426654_GG_pos.Add("rs140587", "G");
            rs1426654_GG_pos.Add("i5001888", "C");
            rs1426654_GG_pos.Add("rs140586", "A");
            rs1426654_GG_pos.Add("i5001951", "A");
            rs1426654_GG_pos.Add("i5001883", "C");
            rs1426654_GG_pos.Add("i5001943", "T");
            rs1426654_GG_pos.Add("i5001885", "C");
            rs1426654_GG_pos.Add("rs55831697", "C");
            rs1426654_GG_pos.Add("rs140592", "A");
            rs1426654_GG_pos.Add("i5001881", "C");
            rs1426654_GG_pos.Add("rs11635140", "C");
            rs1426654_GG_pos.Add("rs7165060", "C");
            rs1426654_GG_pos.Add("rs140583", "G");
            rs1426654_GG_pos.Add("i5900418", "T");
            rs1426654_GG_pos.Add("i5001953", "T");
            rs1426654_GG_pos.Add("rs16961033", "G");
            rs1426654_GG_pos.Add("rs17361868", "C");
            rs1426654_GG_pos.Add("rs8033037", "A");
            rs1426654_GG_pos.Add("rs25457", "T");
            rs1426654_GG_pos.Add("i5001954", "T");
            rs1426654_GG_pos.Add("rs9806163", "T");
            rs1426654_GG_pos.Add("i5001937", "G");
            rs1426654_GG_pos.Add("rs16961065", "C");
            rs1426654_GG_pos.Add("i5001889", "G");
            rs1426654_GG_pos.Add("rs4775765", "T");
            rs1426654_GG_pos.Add("rs6493327", "G");
            rs1426654_GG_pos.Add("rs755251", "A");
            rs1426654_GG_pos.Add("rs12324002", "A");
            rs1426654_GG_pos.Add("rs6493328", "A");
            rs1426654_GG_pos.Add("rs1871484", "T");
            rs1426654_GG_pos.Add("rs5027380", "C");
            rs1426654_GG_pos.Add("rs12906911", "CA");
            rs1426654_GG_pos.Add("i5001884", "G");
            rs1426654_GG_pos.Add("rs605372", "T");
            rs1426654_GG_pos.Add("rs598029", "G");
            rs1426654_GG_pos.Add("rs17363343", "G");
            rs1426654_GG_pos.Add("rs10444797", "G");
            rs1426654_GG_pos.Add("rs683282", "C");
            rs1426654_GG_pos.Add("rs10519185", "T");
            rs1426654_GG_pos.Add("rs12915677", "C");
            rs1426654_GG_pos.Add("rs7183203", "T");
            rs1426654_GG_pos.Add("rs12591273", "G");
            rs1426654_GG_pos.Add("rs7169848", "T");
            rs1426654_GG_pos.Add("rs16961205", "C");
            rs1426654_GG_pos.Add("rs657635", "CA");
            rs1426654_GG_pos.Add("rs1354738", "T");
            rs1426654_GG_pos.Add("rs17364665", "A");
            rs1426654_GG_pos.Add("rs1876207", "G");
            rs1426654_GG_pos.Add("rs363853", "A");
            rs1426654_GG_pos.Add("rs668842", "T");
            rs1426654_GG_pos.Add("i5001949", "G");
            rs1426654_GG_pos.Add("rs1678979", "T");
            rs1426654_GG_pos.Add("rs1876206", "T");
            rs1426654_GG_pos.Add("i5001897", "G");
            rs1426654_GG_pos.Add("rs25403", "G");
            rs1426654_GG_pos.Add("rs16961239", "A");
            rs1426654_GG_pos.Add("rs1807301", "A");
            rs1426654_GG_pos.Add("rs1036477", "A");
            rs1426654_GG_pos.Add("rs1567074", "G");
            rs1426654_GG_pos.Add("rs2118181", "T");
            rs1426654_GG_pos.Add("rs1827918", "T");
            rs1426654_GG_pos.Add("rs1678983", "T");
            rs1426654_GG_pos.Add("rs2247876", "T");
            rs1426654_GG_pos.Add("rs6493331", "C");
            rs1426654_GG_pos.Add("rs25398", "C");
            rs1426654_GG_pos.Add("rs6493333", "C");
            rs1426654_GG_pos.Add("rs2289136", "A");
            rs1426654_GG_pos.Add("rs1848053", "A");
            rs1426654_GG_pos.Add("rs2099562", "G");
            rs1426654_GG_pos.Add("rs10493625", "G");
            rs1426654_GG_pos.Add("rs16961323", "A");
            rs1426654_GG_pos.Add("rs1566816", "T");
            rs1426654_GG_pos.Add("rs10851470", "A");
            rs1426654_GG_pos.Add("rs12910178", "T");
            rs1426654_GG_pos.Add("rs7175415", "CT");
            rs1426654_GG_pos.Add("rs2725544", "A");
            rs1426654_GG_pos.Add("rs1072994", "TG");
            rs1426654_GG_pos.Add("rs1114254", "C");
            rs1426654_GG_pos.Add("rs17463995", "T");
            rs1426654_GG_pos.Add("rs2413913", "C");
            rs1426654_GG_pos.Add("rs12594187", "CT");
            rs1426654_GG_pos.Add("rs784414", "C");
            rs1426654_GG_pos.Add("rs784416", "C");
            rs1426654_GG_pos.Add("rs784417", "GA");
            rs1426654_GG_pos.Add("rs804319", "CT");
            rs1426654_GG_pos.Add("rs7180856", "T");
            rs1426654_GG_pos.Add("rs809207", "GA");
            rs1426654_GG_pos.Add("rs784405", "T");
            rs1426654_GG_pos.Add("rs16961518", "A");
            rs1426654_GG_pos.Add("rs1677249", "T");
            rs1426654_GG_pos.Add("rs12185099", "C");
            rs1426654_GG_pos.Add("rs784411", "CT");
            rs1426654_GG_pos.Add("rs16961533", "CA");
            rs1426654_GG_pos.Add("rs1677251", "G");
            rs1426654_GG_pos.Add("rs16961587", "A");
            rs1426654_GG_pos.Add("rs2289178", "C");
            rs1426654_GG_pos.Add("rs8041414", "GT");
            rs1426654_GG_pos.Add("rs11631110", "T");
            rs1426654_GG_pos.Add("rs9302144", "C");
            rs1426654_GG_pos.Add("rs16961610", "G");
            rs1426654_GG_pos.Add("rs7179618", "CA");
            rs1426654_GG_pos.Add("rs11631496", "T");
            rs1426654_GG_pos.Add("rs17465874", "G");
            rs1426654_GG_pos.Add("rs7170604", "A");
            rs1426654_GG_pos.Add("rs2289181", "G");
            rs1426654_GG_pos.Add("rs6493339", "C");
            rs1426654_GG_pos.Add("rs8035205", "A");
            rs1426654_GG_pos.Add("rs4482220", "G");
            rs1426654_GG_pos.Add("rs2899423", "GA");
            rs1426654_GG_pos.Add("rs2304546", "T");
            rs1426654_GG_pos.Add("rs8037097", "C");
            rs1426654_GG_pos.Add("rs2413914", "T");
            rs1426654_GG_pos.Add("rs4775775", "A");
            rs1426654_GG_pos.Add("rs11070654", "C");
            rs1426654_GG_pos.Add("rs2304547", "A");
            rs1426654_GG_pos.Add("rs1062124", "A");
            rs1426654_GG_pos.Add("rs3743292", "C");
            rs1426654_GG_pos.Add("rs1426199", "G");
            rs1426654_GG_pos.Add("rs16961695", "A");
            rs1426654_GG_pos.Add("rs4775777", "A");
            rs1426654_GG_pos.Add("rs17382306", "G");
            rs1426654_GG_pos.Add("rs2413917", "T");
            rs1426654_GG_pos.Add("rs8040253", "C");
            rs1426654_GG_pos.Add("rs12906456", "C");
            rs1426654_GG_pos.Add("rs16961728", "T");
            rs1426654_GG_pos.Add("rs16961733", "C");
            rs1426654_GG_pos.Add("rs7183535", "G");
            rs1426654_GG_pos.Add("rs1974961", "T");
            rs1426654_GG_pos.Add("rs9672326", "T");
            rs1426654_GG_pos.Add("rs10519192", "G");
            rs1426654_GG_pos.Add("rs10519193", "CT");
            rs1426654_GG_pos.Add("rs10519194", "A");
            rs1426654_GG_pos.Add("rs4435197", "T");
            rs1426654_GG_pos.Add("rs9806753", "G");
            rs1426654_GG_pos.Add("rs1426203", "G");
            rs1426654_GG_pos.Add("rs10519197", "T");



        }

        public byte[] Zip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }

        public void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                int europe = checkIBD(dialog.FileName, rs1426654_AA_pos, "rs1426654", "15", "AA");
                int africa_asia = checkIBD(dialog.FileName, rs1426654_GG_pos, "rs1426654", "15", "GG");

                if (europe == RESULT_NA && africa_asia == RESULT_NA)
                    MessageBox.Show("Insufficient Data.");
                else if (europe == RESULT_TRUE||europe == RESULT_PROB_TRUE)
                    MessageBox.Show("European Ancestry.");
                else if (africa_asia == RESULT_TRUE||africa_asia == RESULT_PROB_TRUE)
                    MessageBox.Show("African/Asian Ancestry.");
               else 
                    MessageBox.Show("Mixed Ancestry.");
            }
        }

        private int checkIBD(string file, Dictionary<string, string> ibd_gt_ref, string rsid, string chr, string target_gt)
        {
            List<string> match = new List<string>();
            string text = getAutosomalText(file);

            StringReader reader = new StringReader(text);
            string line = null;
            string[] data = null;
            bool is_match = true;
            int error_count = 0;
            int allowed_errors = ibd_gt_ref.Count * 4 / 100;
            //StringBuilder stmp = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("#") || line.StartsWith("RSID") || line.StartsWith("rsid"))
                    continue;
                line = line.Replace("\"", "").Replace("\t", ",");
                data = line.Split(new char[] { ',' });
                if (data.Length == 5)
                    data[3] = data[3] + data[4];

                if (data[1] == chr)
                {
                    //stmp.Append(line);
                    //stmp.Append("\r\n");

                    if (data[0] == rsid)
                    {
                        if (data[3] == target_gt)
                            return RESULT_TRUE;
                        else
                            return RESULT_FALSE;
                    }

                    if (ibd_gt_ref.ContainsKey(data[0]))
                    {
                        if (ibd_gt_ref[data[0]].Length == 1)
                        {
                            if (ibd_gt_ref[data[0]] == data[3][0].ToString() || ibd_gt_ref[data[0]] == data[3][1].ToString())
                                match.Add(data[0]);
                            else
                            {
                                if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                    continue;

                                error_count++;
                                if (error_count >= allowed_errors)
                                {
                                    is_match = false;
                                    break;
                                }
                                else
                                    match.Add(data[0]);
                            }
                        }
                        else if (ibd_gt_ref[data[0]].Length == 2)
                        {
                            if (ibd_gt_ref[data[0]][0].ToString() == data[3][0].ToString() ||
                                ibd_gt_ref[data[0]][0].ToString() == data[3][1].ToString() ||
                                ibd_gt_ref[data[0]][1].ToString() == data[3][0].ToString() ||
                                ibd_gt_ref[data[0]][1].ToString() == data[3][1].ToString())
                                match.Add(data[0]);
                            else
                            {
                                if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                    continue;

                                error_count++;
                                if (error_count >= allowed_errors)
                                {
                                    is_match = false;
                                    break;
                                }
                                else
                                    match.Add(data[0]);
                            }
                        }
                        else
                        {
                            if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                continue;

                            error_count++;
                            if (error_count >= allowed_errors)
                            {
                                is_match = false;
                                break;
                            }
                            else
                                match.Add(data[0]);
                        }
                    }
                }
            }

            //File.WriteAllText(@"D:\Temp\" + Path.GetFileName(file) + ".7", stmp.ToString());

            if (is_match)
            {
                if (match.Count >= ibd_gt_ref.Keys.Count * 0.9)
                    return RESULT_TRUE;
                else if (match.Count >= ibd_gt_ref.Keys.Count * 0.5)
                    return RESULT_PROB_TRUE;
                else
                    return RESULT_NA;
            }
            else
            {
                return RESULT_FALSE;
            }
        }

        private string getAutosomalText(string file)
        {
            string text = null;

            if (file.EndsWith(".gz"))
            {
                StringReader reader = new StringReader(Encoding.UTF8.GetString(Unzip(File.ReadAllBytes(file))));
                text = reader.ReadToEnd();
                reader.Close();

            }
            else if (file.EndsWith(".zip"))
            {
                using (var fs = new MemoryStream(File.ReadAllBytes(file)))
                using (var zf = new ZipFile(fs))
                {
                    var ze = zf[0];
                    if (ze == null)
                    {
                        throw new ArgumentException("file not found in Zip");
                    }
                    using (var s = zf.GetInputStream(ze))
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            text = sr.ReadToEnd();
                        }
                    }
                }
            }
            else
                text = File.ReadAllText(file);
            return text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.y-str.org/");
        }
    }
}
