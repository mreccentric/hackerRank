﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using FluentAssertions;
using NUnit.Framework;

namespace hackerRank
{
    [TestFixture]
    internal class Solution_Tests
    {
        [TestCase("tabriz", "otorin", 2, 4)]
        public void Test_GetMaxSubstringLengthInternal(string s1, string s2, int maxDixx, int expected)
        {
            var res = Solution.GetMaxSubstringLengthInternal(s1, s2, maxDixx);
            res.Should().Be(expected);
        }

        [TestCase("tabriz", "torino", 2, 4)]
        [TestCase("uvtedmbqjjazboxbephroffzguecvykbhyafuhsohmetnmdgqpihumsmoxirjrupgnocppctglnmbvolxuubohegeofgshufltgguaymvyoxpmdklbgkdkkzscsxcxcslistafhkzoisxkkqdqavjnuommxxteuxzgfvmusxlsqdueejicvbkizfbvodusbvruqxbcodzybsxazdglvxzzgnsudxfrbtqrfooprbdoxnodpblnlrypdobzgqnsigezdpkhkphonxgabnkgjsvypcrcgehiehljruykpduxoesekjfpbfpxqmyknvrjncmcretfcolzuabqzlezdyopnrsqpuhzzkmgchbsiohnydxydeytxntrpnxhatiqukhsflcifiehccbhjfgnrettuyxktgauboqulrhymjnxzqhcqsfdmmhgiepbbrmhznkfnadvlfplhcszuyzotbxkuysbqleqnypigncvicnjirkvdtdikzdyfmzeccuxmtorcaapjrsahkylcmsejsaumgmlhrofrlvkqglxcnrqmebuuuvaxmatkdnqzoxdkoxuqkrhcoqjbvbmgjrzohthnhqaanngsxqephzmqesecfccsakgznnjmhoucjtebvzigoryroprrmiidxyrtpocniqoalxqhloxcdplhuvthqsyjznbqmantrbxgoqgdnzyhvpovndgkxmsszfbaqkoimnyxsbvavxmkxhkzoedijyspvzsjknrcvradybzeanesxxuzvxmqtjabnmlcnayysgjxrfsjrcjaoyuliehuqyyoxpezfgxxhgsihqomhppjyitiyiyikomklvuoxbkemkervhucidnoynxcyflyqleagpqkgmnquueexspnoxqpapdatsfzzihiusagklunvcvaavslybundctzqdzfercjpjieobdemnnxbivroxkfhdvhqztcrlsvakyhchaluknxkpknoyrbyyrbuidvjlknssyurtvelfxfletkssjgnlveiysfkajkedvmxarptqrxpnitltailrgbcjjhoyyefdgrbbxzijryihyucszdlijikkivckzkipzclefeeypbstotofgnrovyczkeucfmlcxqyjumlavxutlqaxvtyixeshykftrmjxrzmihffngmdtssnkmvkrhveqocynehdysdevpqfpkkequfavldkibfokesqcpjhmuvamkxebfodaczprkhbblnrliullczyeotqmuyzvsibslxnatqtfarkltzjbfsyaysitcsfohbnpjzopnxeknrecknphcoerfgpzxroyvmunryapmjglacplehabtlgfczttgyvilikbinxskheksgfmaxvlgayfjfebtgsmoprknxvhzzmyaotblsdallzpdzkscgteuhfiygojbdotdorfalsxjjnnjvtdacharuhxrthmkpbobvrjcooonqqzpuvmjcsffzx",
            "vlceyrlgrugkjoblzfxneijkrhrfgvytmmesgbcfphagtdezgjazvytozaplhfpeqxbzxefoiknedxvongyslxzlkaeisjbvgsnnauhkiivbfqkpkjiyjsyftrjtkykixfdiojerqebljlqqmttlfzdutumbsgvlohimtajbpppqznxyejzutljuuylastgbykmnyzthyqzvrtjceuhcmnzfzxseaxxzuynzxynipeidmzsroyuahxtkubeecikuayybyxrnzyafxgkazrovhgsypljpclpzqnlfojosubpfhgstvpxylxbjoqlhthiljdcsqugbgxyltydujmqcbpuytzqrbjptomiromzybicefazzmmredurkvgdrqzvdtrrsimpdzxsogsvreflykbrmleebvdxmurmpnxypetrviatqddkbdmggarlndiovgqpkutyjhkagmpcyirkrffyyvxagvpeyhhefsgcfiupmaydlcmegrhejkgmqtldhgudrltepagpgpfxoqplooskudszfvqobcckexqserdduxfmgkypgcsohcmfyrxrbvgggnfhehhkeckttxrpgrlxsrxetcdnsqesvifajnjlhtceiickvneiamkxonftamyuollbfzvjpecaquzimjpjckajvfjzcfgbhzqaougndjbjrgbvyhetpaxfjdlnrlmlstdplpyxggbokhsretpbzrddmgbuksexevratqkagtmacfcfelbpprbvtgipntbgtluuccoxpxexnyellnjcshsprjdliepcdsjjqsemkujlnzeiburrzubtfbdkuolqnoejjfkzmgxgebyygajffjttyeqojsyeeadbbyayrskmgajvexyyyxvxtcqlqsrqlelrdeuxidrpiyfjczjlauseyuqzkcyzoytubljggpbstgvcgqehpciurrjjrpxxhvsmdnrezijvqcvyzsubfidltxhijmtaprjsoieoabzxsqzvtexsxgdxbiztnqlrjocrclecpbsaeszgqzooliazpebzelvdmvxvormexinetkbtcxaxokulrboqlmmcrsrviclyxtgaymxhharimlaanfqpshuadxghtevlcajmtmqtyvokjxccieuaxpsmegmhjuaxlclmblbpkabtqrmrspsippxtydrodctnbignjoyacldgtsotovqqeejbqiaskghqfegdijlrvkdecgxzdfjlolbimzialprvsdnjljqltyczvhbtdoeechkosiydsceenaafvdgkgdlidzzoiogvjnafcsymrrkylnqjkpzvnbzgsarorudfryeitybpaqziltyplfepguixbblvzzqrcmyvfjggpsvtdgccqyfyukyxxycnetjnaavehnuehlvtaifykkazkcklfqllxreltmzmxhcqhizjymdezzjlgussulurgykaeevmpmabjjprnpxvnztfgnbqmbhue",
            31, 40)]
        [TestCase("iareifjvcrckltvlhlptjrkfmsgzdxaaqrsjnxsyervevfvsghstodesloepremnecaohpghcfkhacqessakgpojjgpiznebrpenssdmajlmeunjhzfsgjcqorgzekcyzicoqhrfvxfbryjoqpqckvmkvpryasfmtaejemlyzcgvfnsqystlsfplllnqniopzgeygvgybacykiqszbolkgcpyfpcjhmahbmvatvytduipisafrspshksqonpccslzheubokbyqrmakuigilajiztulojmlpksqgftaztlkcijbdqirlbpdfjhlpzqqbyjbkzqizvegudnkoxyaegecbuutpvkvxhbebrigmggnfkjapqhfulruinnlvmszxbvinnmtyfxicixyfehkoiidapooymjorqkpzzldimvufafvqbgqcotmuircepzzpuauaanssdaebxajqshbshypbscdbdjxekurpngkrcemmdvrspulhkkyvcgkmkyhuongukyjafarfxhxhyxnfduahavnxlarqlxccppasrsbsxzquvfdlxlopenrlpsohhsirbuosxqxeuvqhlrpilkmrahbvnsouuuuzloagepekmjeyipnzgeqofconrqbolsybuashpztffcqdeeqxkicnbcpaunqdtufdyhdnmvnpeoclfqrtxmpedledeyluvfjaplodyxdrgasuvmciofuvtehvrpfqpkplihqirroxfgghutogxeyxqrpdfshqjqdahjajpxnzmdtiimenbdomoqyhpdoqjtjxjnfkqhagudavpekdifjvpcpvfztqgtfrkhbnocunnhpduccisdyigmdqlenxzurcazixxsxvppsplolvloifzjtamryvqyajuetrvkzsfhndczfnpusfycauqhdmvnkgcvshqmpqngrhldcjgmahpinsctdrrdfhgbuplscfervdtpogimjcyhgovgqlbtxssnqdtouvzkgsteoyzehcgrniropfjmdzszbmaeocyeujumedksliarevuqbjcglzitizfbcbhkuffvgoggcvmakqilngnddrgrlqjoyfxptxfmraqeraxooqbjpukyqhpzopnbeyumcjmmvqyypqblenlaoezxxmiuczrqguvqoydkvliytslzvhddyobatmvpnemkmjysbabdnfydtjpetldfqtnavbdtlgjttzhspxcyyamgochsqflcupioqsuejlkvddavjdgymgplryquzqejuyojfysjnmmbjbskuzylaoikbavhuroepcedvddxchxoceukhdrmoukrjjmemopqdqsuumvkuvdgsxkosvzgpunxkiokhjxxfflcenybszkmcyjbhzxhumdxhain",
            "asjqprroaxfhqjqapovlunzhkmzrdguevtzdngtgeadhjzxkrztkgtxqokrajbfzoyoptdzfcurafxjecedcqizkogavgrkoeqqatggngzstidjvdjdrdxnfgdqkhyonxxkmpqijfpvgmhxbblahfrrejnakvgarxdnamqlvjrmixuyuiqnpysbjahfcqyymlipigqhmpqnoijpydaatovkeqnxygmchhiqubkotlznkcvqbxfmytlapczfblanqxrexzoxqeixfyntvheplajfmbxsffhueqfizzarpeeinloczbdsspgmqkfmidiruxtxrcfuompaxafdjqmzdsxpzigtlqmvyczzvptocntaqelgjfnmgqrrkjisqanxxtqsvxlduzdunqurzitvhsunqdsykenvmncekhvqmjsvzuphvdgqsiccbgccmsratjiuafhqmycisoqkxntasfvkhhiiujrjieipoxcbbyjzrhncbcxvezqmcktglyessclepfxkeeygtyuvxtktiagrtzxcoraujlpbuynbpkxsrrsbeagaqcdezlnzqrskrashzmsigtzbkmncayzebsugkbfyxqktvhhqiihtqpnrmfotmunggufobobqffelrqfipvvrvdlttkschhrvfdfecomrrjlfmjxobudaireagdsvdpgikvusbcudrorbhjnqjhppluciblzeryqcdbyjqnpoobogtseynsklzuqouxljqlkcbetrvtgqrjgqmpjuafiyczhldmipqmytkfkloeidaokspuimoxrtdcdzyldkgeebrtxsgipvodjqaqsojuxvitpnucduudjprthyclvkzdilrsikttyndftkigbcvaicafcpzigklpczifduugucxxudnlvstaxkjrrzfrgvuusrpfzdniaqqaiyqbqqqcojtxyjboxxdpzndqrqvrhptanjsymtaeorhosjgsseiicvyektqbppecfsqllbqxffqvgonvvftxfiqznktmpcilbosyejkmyalfxjqmbvmlkalhaakjrafxxfydgafkrhaiiouvbpouqzgebqadotekylmpviiercniorpcnimcdgavpynxhfuimngalgmglagpxbcicgmjvpxpzhcavdbaltjrougvgyngfsiidyblapguheedcjzskqujulyngudjkogqbooqtqlxycvnifgbvrvhlqbufcughccxnoakyngpdlojddbbizelbqlcyqlbkfffkkzbxgjqerqijtcevixqodqbyhsmugsmdpbehxmhthyafzxbeoihumtsynguzssljknxarkzqonhtbrbckcshezbrmziribgibidsuzxkrnubrgzgebhqvuluefrxpop",
            946, 1011)]
        public void Test_GetMaxSubstringLength(string s1, string s2, int maxDixx, int expected)
        {
            var res = Solution.GetMaxSubstringLength(s1, s2, maxDixx);
            res.Should().Be(expected);
        }

        [TestCase("torino", 0, "torino")]
        [TestCase("torino", 1, "orinot")]
        [TestCase("torino", 2, "rinoto")]
        [TestCase("torino", 3, "inotor")]
        [TestCase("torino", 4, "notori")]
        [TestCase("torino", 5, "otorin")]
        public void Test_RollTheString(string s, int index,  string expected)
        {
            var res = Solution.RollTheString(s, index);
            res.Should().Be(expected);
        }


    }
}
