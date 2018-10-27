﻿using Marathon.Core.ViewModel.Base;

namespace Marathon.Core.ViewModel.SponsorsReview.CharityList.Design
{
    /// <summary>
    /// The design-time data for a <see cref="CharityListItemViewModel"/>
    /// </summary>
    public class CharityListItemDesignModel : CharityListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static CharityListItemDesignModel Instance => new CharityListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public CharityListItemDesignModel()
        {
            Logo = DesignModelHelpers.StringToByteArray("89504e470d0a1a0a0000000d4948445200000489000001da0806000000849019a60000000467414d410000b18f0bfc6105000000097048597300000ec400000ec401952b0e1b0000410549444154785eeddd3fb01565def7eb090c2620202030202020202030302030784f150101010101818181010181a78ac080802a0203020202024e150101010101010101671e745019dd4751999171604445dd2a2a3acce8ccb3cefe2e7b8f80f7de7b75af7fbdbaaf4fd5556f3defcc28dc7badb557ffbafbeedf0d244992244992d4fb0c892449922449926448244992244992244322499224499224ad64482449922449922443224992244992241912499224499224692543224992244992241912499224499224c990489224499224492b191249922449922469b421d1fff57fff3f000000002ca851322402000000e8b851aa3524fa7f7ff73b000000001684211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322e88aab9b360daeefdc397877cf9ec19f5f7861e8f69123833b478f0efdfd955706f7ce9cf9afaf2e5e1cdcbf72e5bf1edebefd986faf5e7dec3fcf7fffd1ff7ddc39766cf0b7975f1efebbf2ef5d7aeeb9c1ebdbb60dff2ca53f23401b5cdbba75f0f6ae5d83f7f7ef1f7e7edd3a74e8bf9f95f1e9a953fffd9cfbfcecd9c73e0b1f2c2d3df659f9c38d1b8ffde7f1c5b9738f7d56e69f977fee87070f0e6e3efffce0fffb3fff67f8799d3f47e9cf0700302f8644b000fef0d4538337b66f1f1e58ac0e7f72d0f1f5a54bc303949fefdfafde81ede97f7ffe7978009503aa1c347d76faf4e0a3c38707efeddb373c38fa9fdfffbef8770518c76b5bb60cfef4cc33831b7bf70e873f1990af0e7af299d4c67e5a5e1efed9f2675cbe7061f0f1f1e383bfbcf8e270f0fec7a79f2efe3d0100a6c190085a24c3a01cdce4e0e093932707df5fbf3ef8d7bd7bd5bbab7bfde3d6ade1a02b7fd71ccce56a2467d68151641894415086e619ace4f3e43f0f1f569f2edd2a2702f2fb205728e58aa40f0e1c18bcf5ecb386ed00c0c41912c19c9406425d3dc0a9db3fefde1d7c79fefcf0caa39c49772004fdf6e440289f111a0c7f677c77eddae0ee8913c3c1516ef72dad1f00c0a80c896046728b958150b372eb5a6e5bcbda653f8f3777ec28ae31b0f83214ce55850642cdcaad6b59b7ec17f7ceeeddf68863e1e477fca37b7a4113b9d5f8d1bde672e27175cfce9c74c889da9c8028bd06a1ef0c89604a72a550bea0e70c6f5bf7c158e4726b4986465963571ac162cb6da619a267837c03f4c996f5cc6dbdb9a5d795462c82ecbf28cdaad53d34b3275cf6afcb9e7079c8406ee93564a7af0c8960825eddbc7978a54b7ec9fcfbc183ea5da16997b5ceed6939c8b4c92b2c869cc5cdd9dd5c59a9d995871de40c7b6ee5cdc98cd2cf06e6c990486deac79b37875767e6f7551ebe62d84e1f1812c198f2d4b1bfbef4d2f00c44ce4668fee5a033b7aad8041bda63f536b23c99d12d64ed281b62e7a4466ebd3030a22d0c89d4f672e5517e97bdbf7ffff00471e9750c8bcc90081ac8d52a39a390b30b6a77b9cd22bfc41d00c17c640091b3b0aeae6c77799266ae3072969c793324d2229513c47980408e0b728566e9350d8bc690086ac81797dcd6e48aa1c52b9bb9e63e739b5ec3f46533d06c126a3fb6c52c57c6e66969f67b631e0c89b4c8e5f75e064606ee2c324322d8402e23cd869fae1aea4edf5ebd3adc3bcad5453059d9e8334f95b1f97437ca703d0f08c86dd5a59f374c832191ba5206ee799a9a0db059348644b0866caa9afb8d1dec74b73c212dbfbc0d8ba0b95c6d92f7910da8bb5bae9ecdf0cfb08859302452d7caedd639a6f019caa230248247e460275798e4de62f527c322a82f97d2e716ce5c6da27e6458c42c1812a9abf90c65511812c18a0c073224c8c69dea6f8645b0b16cdc9f2fb9f666eb6f0e7498264322753d9fa1b49d2111bdf7ceeedd83074b4bd52b58fa65589427a2955e2fd057d99fedceb1636ec1d57f5b3dd0c946e5a5d70c346148a4bee43394b63224a2b7aeefdc397c3cbab4565f5dbc38b8b6756bf1f5037d912beb3e3c78d095965ab39fefdf1f5e85597afd405d8644ea5bb96ddbc949dac49088dec9ad129f9d3eed56098d54361bfceb4b2fb9058d5e7a6fdfbee19575d228e5493e6feed8517c2dc1a80c89d4d79c9ca42d0c89e88d6c4a7de7e8d1e141bf54b76c669e27de955e5bd03579947d0ef8a5bae576c4db478e18acd3982191fa9c2b33690343227a214f2c73ab84c62d579ffdfd95578603c7d2eb0c165dce607e71ee5cf58a979af7c38d1b83b777ed2abece603d8644d260f0f9d9b3be6f32378644745a36825bbe70a17a754a9329073f6ea9a06bb21f42ce604a932a83f55cc15b7abdc15a0c89a45ffafefaf5e13619a5f7094c9321119df5ee9e3dae1ed2d4ca6d8bd9afa5f4da83457275d3a6e1194b695a659f8d3c1daff4fa8327191249bf966399dc025e7aafc0b41812d139b934f3ee8913d52b529a6e7924b8bd375854b91de8e1eddbd5ab599a5ed9003d4f152dbd0ee1518644d2e3e5c4e407070e14df2f300d8644744a3616cead40d22cfbe6f2e5e1ad8da5d724b451069b19707acaa366590e74b24760e93509ab0c89a47279da6ee93d039366484467e483334f5591e651aec67039308be0f56ddb864feb93e655aef67505266b312492d6cea08859302462e1e5693cb992439a77195266f3dfd2eb14dae02f2fbe38bc9a439a77f7af5c19ee87557a9dd26f8644d2fa1914316d86442cb47c91f86979b97af549f32fb7ef1814d136b96ac3e6d46a5bdf5ebd6a50c46f1812491b6750c4341912b1b072206e3f0db535bfbc698b1c84e7605c6a633fdebce911cf3cc690481aad5c1d5c7a0fc1b80c895848390097dade47870f175fbf302b39f8b699bfda5e0645b975bcf41aa67f0c89a4d1cac9f2bc5f4aef23188721110be7e3e3c7ab579bd4feb2416be9750cd3f6e68e1dc3c78e4b8bd0bfeedd1bbe664baf65fac590481abd7c761ab2336986442c0c7b6a6851332862d6dedeb56bf8c5515aa40c8a084322a95edf5fbf3ef89fdfffbef87e82260c895808d953e3eb4b97aa5799b4781914312befecdeed09665ad80c8a302492ea77efcc99e2fb099a3024a2f5b2a7c677d7ae55af306971b39935d3f6c1810336f4d7c26733eb7e3324929af5e1c183c5f714d4654844abbdb17dfbf0cba2d4953c1e9f69b1a1bfba544e0e793c7e3f191249cdca55c4af6fdb567c5f411d8644b4563661b3a786ba56aef2587aeeb9e26b1e9a32205217fbeae2c5e17e84a5d73cdd65482435ef9bcb978bef2ba8c3908856cad9435710a9abe54c8f3d379894dc622675b5cf4e9f2ebeeee92e432269bcfefcc20bc5f7168cca9088d6c959c3fb57ae54af28a99be52a397b6e30ae5c95660f2275bd3b478f165fff74932191345e3fdfbfef3b26633124a275be3877ae7a3549ddeec1d2924796d258ae46f31433f5a55c31577a1fd03d8644d2f8e578aaf4fe82511812d12a7f7fe595ea9524f5a34f4f9d2abe17603d394368cf36f5a90c44f3308bd2fb816e31249226d39f9e79a6f81e838d1812d11a796ca3d4c79c21a78eecd9f6c38d1bd5ab47ea4faebeec07432269322d5fb8507c8fc1460c8968851b7bf7da5743bdcd19724665cf36f53d575f769f219134b95c4d44138644ccdd5bcf3e6b5f0df53e67c819853ddb24575f769d219134b95c4d44138644cc55ae9eb0af86f44bce90b39e8f8f1faf5e2952bf73f565b719124993cdd544d46548c4dce4b689efae5dab5e39929233e494e4965c49bfe6eacbee322492269b279d519721117373fbc891ea552369b59fefdf1f3eb9aaf49ea19f5edbb265f0cfbb77ab5788a4d5f244d4d27b86c56648244db6ff3c7c387875f3e6e2fb0d4a0c89988b5cf668a36aa99c333e3ceacbf3e7ab5786a447cbf788eb3b7716df372c2e432269f2e529d2a5f71b9418123173b93cfcc79b37ab578ca452efeed9537cffd02fb9fd50d2dae5b6f5d27b87c56548244d3e9f95d46148c4cc7d72f264f56a91b4560f6fdfb6df46cf5ddbba7578fba1a4f57386bc5b0c89a4e9f4e68e1dc5f71c3cc99088997a67f7eeea952269a3ecb7d16f5f5fba54bd1224ad97bddcbac590489a4e778e1d2bbee7e0498644cc4c364cb3f9aa347ad96fc3634bfbe9d6a143d5ab40d22865efaed27b89c56348244da73c15b2f49e832719123133d98c5752bd720ff91f9e7aaaf89ea29bded8be7df0ef070faa5780a451bbb1776ff13dc562312492a697a79c310a432266c2e6ab52f3ecb7d11f1908663028a97ef672eb064322697abdb76f5ff17d078f322462eab24f80cd57a5e6fdebde3d073e3df1b7975fae7eea929af4d7975e2abeb7581c8644d2f4ba7be244f17d078f322462eaf2612469bcee1c3d5a7c7fd11db904dc405d1aafbc87dc4eb1d80c89a4e9655f22466148c454656f8dff3c7c58bd3a2435cd814ff719a84b93c9507db1191249d3cdf749366248c454dd3b73a67a65481a378f2eedaed7b76d335097265486eaaf6dd9527cafd17e8644cdca7074defefeca2bc3effeb17ce1c2e0fe952b43ffb8756bb867586e9fd7fc7bebd9678bef3d586548c4d4e4d1dd7984b7a4c9942142f6f82abddf586c06ead264b3efc6e232246a56692ddb2857b1bcbd6bd7f0a11c799f7e7de992e1d18ccb03854a3f1b586548c4d4e40c82a4c9e6c0a77b0cd4a5c967a8beb80c899a555acb4592abfffef2e28b836f2e5ff63b71cadd3e72a4f833805586444c855ff0edef9f77ef0e2f01fef2fcf9e1550c193ee452e18f0e1f1efcf98517866778562f1f5ebd74d8d99ef997039fdc9a547adfb198beba78b1fae9aa8dfdfbc183e1469f397059fd2c5cfd6ccc014d3e2ff354bafcdff91ccd7ffec5b973c3ff8d5b08e7dba7a74e15df73b49bef90cd2aade5a2cac0284f2afcf6ead5ea6fa749f6f9d9b3c575875586444c45860f6a4739c0c92028f789e7f2d2dc877c75d3a6e2cf6d54f9e59d2f71f905fed9e9d3c3fbcc35bb72105afab9b0781c0cb5ab0c763258c867dbbb7bf64c64207b7de7cec1fbfbf70f874819b41b1ccdae5c8d900768947e2eb497cfc56695d6b20bf27af03d73b27d77ed5a71ad6195211113f7debe7dd5ab41f32a57097d72f2e4e09dddbb07fff3fbdf177f4e93f6e68e1dc3ab9072b6dd41d074cb818fdb28ba215fd434bff25eca67d6ad43876676855e3e933380ca67743673d5747335d1e231246a56692dbb229f9b1f1f3fee36b409f5d3f272719d6195211113f587a79e1a9e89d5eccbd35cf20b34fb9b947e36b3942b9572d0f5e3cd9bd59f4e932e578695d69ec561a03ebf720bc3cde79f1ffbaaca49c89546196418ae4fa7acab279d2d1643a26695d6b26b7235bcef9693a9b4beb0ca908889cade0c9a6d39139d81ccacae18aa2b67ccedb932f932146cebcf9c8d65a0ee2a92d99633d0d987a10d83f4920c32b2b751ae04d564b349eb6231246a56692dbb285752db1f73fc4a6b0bab0c8998a81f6edca85e099a76b94de5c6debdc59f431b655f88ecc7a1c995cdc54b6b4dfb658f1acda65c4972e7d8b185b9453303c4bcb73308d664ca01a5a1fae230246a56692dbb2a5b1c18148dd7b5ad5b8b6b0b6148c4c4bcbd6b57f52ad034cb7dc479a24ee967b008728b8d2b2826532eb92ead31ed67603a9b962f5c58d8a701e6caa23c18c01e1c9329573a97d699f631246a56692dbb2cc71d79388b9ae549b9acc7908889c9139734dd72c0d085bd1572463797ff3bf819bf45ba9a8c5fe48b99a65b9e8493817469fd174df6e0f8fefaf5ea6fa6a665bfc4d2fad23e8644cd2aad65d7e549946a56aec62aad2984211113f1eae6cd36dd9c62b96224674c4a6bbfc872f0e3b1a6e3952b524a6b4b7b65d3714dafac6fd76e2dca2d68774f9ca8fe866a5af6c82bad2fed6248d4acd25a769dfdfd9a97f759694d210c8998883cfa5cd32943800ce14aebde05f9bbe59610352f4f472aad2ded932fb4f651984eb9ed207b3d95d6bd2b727594bd8a9a67a8be180c899a555acb3eb0c75fb30c89588f211113e17194d3298fb4cf416569cdbb26970cbbfdac59797c76694d691f5f66a753ae486ceb53cb262db72bbafdac7986eaed6748d4acd25af6c5b757af56aba051ebe21d0a4c8e211163f3cb7cf2e5d6bd3e6eb299036883a2fae50a0a4fee590c36ac9e7cf7af5c599827974dcad54d9b1c14352c275f4a6b4a7bf85ed9acd25af645be33ab5e36ae663d86448cedcbf3e7ab9fbe26510ef8979e7baeb8d67d904191a755d4efe6f3cf17d793f6b061f5e4cbef9fbe5c6df9a40c8abeb97cb95a098dda3fefdeeded6b6651181235abb4967d911305aa972111eb3124622cf95076e5c7e4ca5a7a5ad5ef86433283a27ad96ba3fd6c583dd972254ddf0ff6f3f777a2a67eefecde5d5c4fdac190a859a5b5ec13b7e1d6cb9088f518123196bfbdfc72f593d7b86540d4f54d57ebc8a0c813f3462faf9f6b5bb716d792f9cbc1bc0dab27570644b992a6b4d67d93d796cdffeb75efcc99e25ad20e8644cd2aad659fdc397ab45a098d92dfa1acc79088b1787cf9e4facb8b2f16d7b8cfdc635eaf3c65b0b48ecc9f0dab27571e94e0cbede3b21e3fdcb851ad9036ca3e6eed6648d4acd25af649ae10d468fdb4bc5c5c4358654844633e8c2757aec82aad31bf1b6e32aad1ca4162690d993f577a4ca69c98e8db26d5a3caad03f9e2afd1b28f5b7b191235abb4967df2c6f6edd54a68a3726b5e690d619521118d39789f4c39782cad2fbfc8ad149e08357a7d790cf822c9150b6e9d1cbfdc52f9d6b3cf16d7985fe4e0da3e81a3651fb7f632246a56692dfbe4b52d5baa95d0467d71ee5c710d619521118de5927f8d57ce8abfba7973717df955d6c8ad8da375f7c489e21a323fefeed953fd74344e7f7de9a5e2faf2b8ac93362ec33457a5b5932151b34a6bd9371aad3c48a3b47eb0ca9088463cca79fc9c15afc797c6d1caed267d7fe253db7c7aea54f5d351d35c7159cffd2b57aa95d37a193cb693dff7cd2aad65df38a1385ad9f3b3b47eb0ca9088466e1d3a54fdc4d5345f4eeb73b05d2eb7327d77eddaf02aa26c906c43d676f9e7ddbbd54f4a4d72c5657d3991e316c772793f7e79fefcf077f0f59d3b8bebc77c191235abb4967d6348345ab6266023864434628f98f1faeae2c5e2bab2be1c287a8cf8e307396fefda6528d4623908d578b9e2b2993c10a1ef3d3940bfb6756b71ad681743a26695d6b26f0c89362e4f7774c5391b3124a2369bb08e576e33cb13184a6bcbc6fab6df86839cc576fbc891ea27a926dd3b73a6b8ae6c2cbfabfb36543740ef0643a26695d6b26f6cdcbf71df5ebd5a5c3b78942111b5ddd8bbb7fa69ab49368b1b4fd70f7c1ce4744bbe8ca9593fdfbf6f63e1317579a86e80de5d8644cd2aad659f5cddb4a95a09ad97079c300a43226ab32f4cf332dcc82d53a57565745d39f07190d36d791cafb39acdcbed52a57565745d1aaa1ba0f7872151b34a6bd9271eaa335af9be595a3f78942111b5b9dfb7799e2630193938c855068b96839c7eb9f9fcf3d54f5e75fbc7ad5bf64c989045dc9bc800bddf0c899a555acb3ec9f72aad5f4e5ce58aabd2fac1a30c89a8e5cd1d3baa9fb4ea96b3b9860293f3c9c993d5cab63307397c71ee5cf56a50dd32482dad29f5e596bdb65fd16680cea30c899a555acb3ef9cb8b2f562ba1b5fae6f2e5e2dac1930c89a8c5d3529ae7d689c96adb53a31ce4f0a85c05b38857bbb5a1ac9bf7cf64e5b3a92d19a0b31143a26695d6b24f9c98d9b80f0f1e2cae1d3cc990885a328156fdf2b8497b114d5e0e34e691831c36b2f4dc73d5ab4575bb73ec58714d69eedd3d7baad59d7d06e8d46548d4acd25af68913331be7fb2aa33224a2161fc0cdca30a1b49e8c277b3ccd220739d495d78aea9701ac279a4dc72cf613344067120c899a555acbbeb01fd1c679f43d75181231b237b66faf7ecaaa5bd6aeb4a68c27c39a5ca535c91ce430099f9f3d5bbda254a7ac5b693d19dfed2347aa559e5c06e84c832151b34a6bd917d3f87ceb5a79984669eda0c4908891e58059f57bb0b4545c4f2663dc837107394c43def7aadf7bfbf615d793f18d7ba2c7009d5931246a56692dfb20dfdbf27018addd4fcbcbbedf528b211123fbf8f8f1eaa7ac3a65f8505a4f26230795a3e6208759c817b1b63f4daa8de54bacc7de4f579de1a5013af36248d4acd25af6c147870f572ba0b5fafb2baf14d70ed66248c4c8beba78b1fa29ab4e0611d39503971c5c967290c33cfce99967aa57a0eaf4d9e9d3c5f56472d63a983240a74d0c899a555acbae7b75f366fba56e504e5abdbe6d5b71fd602d86448c6cad0371ad9d4de2662307970e72688bbfbcf862f509a03abdb37b77713d999c7c2e260374dacc90a859a5b5ecba3b478f567f7badd5bd33678a6b07eb31246224ab5f2c552fb79acdc6d54d9b1ce4d01a9f9c3c597d0268d4dc6a363baf6dd952fcff87b630246a56692dbbecdd3d7bdcdabd41591f0fcfa1094322465267df17fd5a6e3b29ad27d05db98250f55abe70a1b89640ff181235abb4965db5f4dc73137fba6d17cb49abd2fac1460c891889cb39eb977ba44b6b09749b2faef573d525b0ca90a859a5b5eca23777ecf034b311ca360c7f7cfae9e21ac2460c891849cef2aa5ece8c43ffe4cbabeae7aa4b60952151b34a6bd935796d18108dd69d63c78a6b08a330246224d9e452f572661cfa279ba6ab5eaeba041e6548d4acd25a76459e6296879468b47ebc79d35e9d8cc590880d65934bd5cf9971e89fbfbff24af509a05173d525f02843a26695d6b20b72f2c5c9ead1cb66d5796a65692d615486446ce8c6debdd54f57a3963d494a6b0974db57172f569f021ab58f0e1f2eae25d04f8644cd2aade5a2ca53956f1f393278b0b454fded346a1f1f3f5e5c53a8c390880d7d78f060f5d3d5a87d7ffd7a712d816ecb25deaa574e4494d612e82743a26695d67291e4ce851c73784268f37eb871c36d664c8421111bcac667aa97474e423f79b259fd72c6b8b496403f191235abb4966d7475d3a6c15bcf3e3bf8f30b2f0caf7af9fad2259b514fa07cffc8c3334a6b0e751912b1a17b67ce543f5d8ddaad43878a6b09745736d654bd6c5a0d3cc990a859778e1e6d850c7e72ec10b905fbfe952b43ffb875cbde4253cc55b94c9221111bca07bbea953324a5b504baebface9dd52780462db71594d612e82f4322a95e19ce95de4bd09421111bcae45ff5caa5b4a5b504baebdd3d7baa4f008d9a5b738127191249a3f7e5f9f3c5f7118cc390880dfde7e1c3eaa7ab51caa671a57504baed2f2fbe587d0a68d4dc9a0b3cc990481aad0c88fef0d453c5f7118cc3908875e54903aa5736e02bad25d06db9dc5bf57a67f7eee25a02fd6548246d9c0111d36448c4bafef4cc33d54f56a3f6d9e9d3c5b504bacd26fff57b63fbf6e25a02fd654824ad9f0111d36648c4bab253beea75fbc891e25a02ddf6cde5cbd5a78046cd975ce0498644d2da1910310b8644acebc38307ab9fac46edcf2fbc505c4ba0db7ebc79b3fa14d028e551c8a57504facd90482a972b960d8898054322d675e7d8b1ea27ab51cb979bd25a02ddf6ef070faa4f018d92c7df03258644d2e3fd7cfffee08303078aef1798064322d6658f8dfabdbe6d5b712d81ee7a75f3e6ea1340a3f6f9d9b3c5b504facd9048fab59c50716cc1ac1912b1aefb57ae543f598d9acb40a17faeefdc597d0268d472a56a692d817e3324920683fffdf9e7e13ea78e2b98074322d6f58f5bb7aa9fac4629b79b94d611e8369bfcd7efa3c3878b6b09f49b2191fadec3dbb7076fefda557c7fc02c1812b1ae7c4869f4b25ea57504ba2d1bd6ab5e36f9074a0c89d4d772b2f9ced1a383ab9b3615df1b302b8644ac2b1ba569f4f274a3d23a02dd6648543f9b7002258644ea5bb9b5ec939327077f7cfae9e27b0266cd908875a95ed9c3a9b48e40b71912d52f0782a5b504facd90487dea8b73e7066f6cdf5e7c2fc0bc1812b12ed5eb9bcb978beb08745bf6d751bd969e7baeb89640bf1912a90fe5c4f29f9e79a6f81e80793324625daad7bd33678aeb08745bf61050bd3cd2172831245257cb9e439f9e3a3578ebd9678baf7d680b4322d694fb62552f4322e82743a2fa191201258644ea5adf5fbf3ef8f0e0411b52b3300c895853bec0ab5e39502cad25d06d8644f52bad23802191ba90ab8658648644acc990a87e8644d04f9f9d3e5d7d0a68d44aeb086048a42ef4f9d9b383f7f6ed73f5100bc99088351912d5cf9008fa29b79aaa5ea5750430245297cae3edbfbd7a75788cf0f6ae5d833f3cf554f1750f6d6248c49afc92ae9f2111f4932151fd4aeb08e0fba7badc4fcbcbc3ab8f3de193363324624d7e49d7cf9008fa299795ab5ea57504f0fd537de99f77ef0eee9e38616044eb1812b126bfa4eb77ebd0a1e25a02dd76ffca95ea5340a39433a9a57504f0fd537decc79b37071f1d3e3c7875f3e6e2fb0266c9908835bdbb674ff553d5a8fdf985178a6b09749b2151bd1edebe5d5c47004322f5b9ff3c7c38bc1dcd53d198274322d6948187ea654804fd6448542f4322602d8644d22f7d77eddaf00969a5f7094c9321116b3224aa9f2111f4932151bd0c8980b51812498ff7606969f0ceeeddc5f70b4c8321116b3224aa9f2111f4932151bd0c8980b5181249e5f25d23ef8fd2fb0626c9908835dd7cfef9eaa7aa513324827e3224aa972111b016432269fd962f5c18bcbe6d5bf1fd03936048c49afc92ae5f9e4a505a4ba0db0c89eaf5ef070f8aeb08e0fba7b471f93dfab7975f1efce1a9a78aef23188721116bf24bba7e778e1e2dae25d06d8644f52bad2380ef9fd2e8e5d1f94bcf3d577c2f41538644acc92fe9fa1912413f7d7ef66cf529a0512bad2380ef9f52bdfef7e79f87c720ae2a62520c8958935fd2f53324827eba77e64cf529a0512bad2380ef9f52b3beb97c79f0c7a79f2ebeafa00e4322d6747de7ceeaa7aa513324827e3224aa5f691d010c89a4e6fdebde3d8fcb676c8644ac29bbe6ab5e8644d04f8644f52bad23802191345eb9fdecaf2fbd547c7fc1280c8958932151fd0c89a09f3e3979b2fa14d0a895d611c090489a4c8e4b68ca9088351912d52f571394d612e8b67c1153bdf23ba6b49640bf19124993ebee891336b4a6364322d6746debd6eaa7aa513324827e3224aa9f2111506248244db62fcf9f3728a2164322d6a57addbf72a5b88e40b77d74f870f529a051cb8160692d817e332492265f6e8b2fbddfa0c4908875fdb4bc5cfd64354a8644d04f7f7ee185ea5340a366480494181249d3e9f69123c5f71c3cc99088753dbc7dbbfac96a94b25ea57504ba2d8f9b55bd32582bad25d06f8644d2f4facb8b2f16df77f0284322d6952b63347a8644d04f6fefda557d0a68d40c8980124322697ae5f1f839b1557aefc12a4322d6b57ce142f593d5a895d611e8364f83ac9f47f302258644d274fbd7bd7b83d7b66c29beff200c8958579ed6a57a95d611e8b6fff9fdefab4f008d9a2111506248244dbfaf2e5e2cbeff200c895897c73ad7cf639da19ffef3f061f529a051ca4988d23a02fd664824cda6bfbef452f13d088644ac2b1f1eaad7f59d3b8b6b09749b8dfeebf5e5f9f3c57504facd90489a4d39b9f5e68e1dc5f721fd6648c4ba3cd6b97e37f6ee2dae25d06ddf5fbf5e7d0a6894b25ea57504facd90489a5ddf5cbe5c7c1fd26f8644accb639deb77ebd0a1e25a02dd962f5a1abd9f96978beb08f49b2151b3720b6f9b7d7de9d2f0a9c9df5ebd3abcf2367ebe7fbffad36b9e7d70e040f1bd487f1912b1aeb79e7db6fac96ad4fefeca2bc5b504ba2d5f8255af6cf85d5a4ba0bf0c899a555acb45726debd6c1bb7bf60cb7baf8f4d4a9e13029271334fdfe79f7eee0eaa64dc59f0bfd6448c4ba5eddbcb9fac96ad4be3877aeb896cc46360ef78b8e79b873ec58f529a051b317c2fcfce1a9a7ac3fad6448d4acd25a76411ed59ed7c4ed2347060f9696aabfad269d93dc3cca90880d99e2d7ebbb6bd78aebc86ce472e66cc497fff72f2fbe383c3355faefc1a4dd7cfef9ea5340a396b3c6a5b564fadedeb56bf833f8c7ad5b83bb274e0c0fc232382afd7761960c899a555acb2e7a63fb7603a32994efceb938a0b4e6f48f21111bcad043a3974b364bebc8f4e5d6957f3f7850fd247e2d1be4de397a7478fb64e97f0793b07ad0add1cb20b7b4964c5f0eb29e2cfb837c7ef6ec70e0e960817931246a56692dbb2e03a38f8f1f1ffcefcf3f57aba071ca77e5d23ad33f86446c28b74fa95ecec6cec7285f2c33c4fbecf4e9e1150cf64361927249bcea955bf44a6bc9f46503d9f5ca4157fe3bd91f240762a57f064c832151b34a6bd917b975367b1869bc72f788efc68421111bb2cf46fdecf3301f755fabb9ea68f9c285e1d50c7f7cfae9e23f13eaf0a4967ad9c36d3eb26f5b6e2da8d38f376f0ef7ac587aee392742982a43a26695d6b26ff27dce3619e3951303a5b5a55f0c89d8907d36eaf7fefefdc5b564bac6bd3532fffbdc82717de7cee23f1f36925b1b357a3fdcb8515c47a62b57528e530ec2725b5a7ed7795000936648d4acd25af651aeea755551f31edebe5d5c57fac590880dd967a37e6ea198bdec9f31c97bd2f34bf293932707efecdeedd25b46e6f6dc7ae53debfd357bd9c36352e58aa46f2e5f1edc3a7468f874c9d2bf0fea30246a56692dfb2ac36b83a2e6e53d585a57fac390880dd967a37e5f5dbc585c4ba6e7bd7dfbaad59f7cb92dedcbf3e78757d5e5fd50faf743e4761cd5cb86f2b337cda702e5eab09c28c909a6d2bf1b366248d4acd25af659beafe53659d5efde9933c535a53f0c8918897d36eae50967b3f7e9a953d5ea4fb75cf990b3537f7bf9657b4ff11bd90f41f5f284b3d9cafe6bb3ea5ff7ee0d1f149021bedbd218952151b34a6bd977f9bc3328aa5fae10f599dd6f86448cc43e1bf5f3f8e0d99ad797807fdcba35b87be2c4f04badcd5cc9a6beaa57de3fa5b5643a3e3870a05af9d996838eaf2f5d1a0e05af6ddd5afcb341181235abb496fc6eb8cfa447e4d7cf099c7e332462243913a87a652f9bd25a3279d907a30de58abb6ce69adbd20c09fb293f77d52b57e695d692e9c86d046d28279fee1c3dea76437ec390a859a5b5e4173919a17a65a85f5a4bfac190889164434ad5cb232467a78db7f8e4ac553673cdebe08deddb8b7f6eba29579769f4325c2dad23d391dba1db56fe4cb965384f5db391398644cd2aad25bfc8ad536dfcec6b73d98fd3e7717f191231929ce953bd962f5c28ae259377ffca956ad5db5b6e87cba6c6b91dc96d69dd96abc954af3f3df34c712d99ac4538f8ce81497e7f66f89ffd444a7f0fbacd90a859a5b5e457f3bad57691cb7bb1b496749f211123c92439fb0968f49c1d9f8db6dc6a56a79f969787b77cbcbf7fbf8d013b28578fa95eaebc9c8db6dc6a56a7dc8e78fbc891e1be22a5bf13dd6348d4acd25af23857fad62b27374beb48f7191231329b57d7cf2380a72f7b5a2c7219bee6b6b4dcd2998157e9efc862b17975fdec7d307d1948e72a9d45eee1eddb834f4e9e1ceef9e73688ee32246a56692d795c861e1abd1cfb95d691ee33246264f962a67ae531e9a5b56472ba768ff983a5a5c19d63c70c1817580ec63d49a55e195eb80d73badab877db38e535f3c5b973c30705bcb6654bf1efcc6232246a56692d799c9338f53390ef27432246d6b52f98b3287be594d692c9c8d9e42ef7af7bf7864f167c6fdf3eb7a52d980cfb542f7b1f4c576edbea6a19cae6ef9713336feed851fcfbb3380c899a555a4b7ecb06d6f5f204ca7e32246264d95854f5caad4426f0d393b3c87d29afa5af2e5e1c0e6baf6ddd5a5c0fda23c33dd52bb78e96d692f16570d2a7b2efc8c7c78f0f870dae505b3c8644cd2aad25bfe5ce887ae57b67691de93643226a59f4fd0ce651ae7629ad25e37975f3e65e6fa69efbc47350ed0c4f3b658f29d52b578294d692f1f5791f8e3c44224f1ccc6d69f9bd515a1fdac590a859a5b5e4b7fc7eaed7dd13278aeb48b7191251cb223c6abc6de5cb69692d19cf87070f562bac5c3afde9a9538377f7ec71e55a4b6478a7fabdb17d7b713d692e57d2b8bde297725b5a1e1490a7e979adb5972151b34a6bc96f79147ebdf299595a47bacd90885af2185ad52b575fd94f66f23c6daf5c5e6fcb172e0c2f0fb699eb7cfdb4bc5cfd54346a6e399bbc1b7bf756abab27fbf1e6cde15556d9ccb6b476cc872151b34a6bc96f797dd52bfb6396d6916e3324a21667c79b95cbdc4beb4933f6c71a2df791cf57ae2254bdb2974c692d692e4363ad5faeb42aad1df3e120be59a5b5e4b75edfb6ad5a318d9abdddfac79088da325156bdbebe74a9b89634934b5fb57136b89eaf0c8755bfb777ed2aae27f579dcf36865a3f9d2fa311f8644cd2aad25bf95dbf255af0cd64a6b4977191251dbbd3367aa9fb6462dfb20fcf1e9a78beb493dbe3c8ed60f376e14d78fd9c9ed7eaa5f9e3c535a4feab38fe068bdbf7f7f71fd980fbfe79b555a4b7e2b5b40a85e794f96d692ee3224a2361bbe35cb5e1b93f16069a95a51ad57f6d928ad1fb3f5ddb56bd54f44a396a751790ad5f8dedbb7af5a51ad574ee2d837b05d0c899a555a4b7ecbed66f5b36d46ff1812515bbebce74b95eae5c0677c0694a3e7ac4f3b6438acfa19aa8f27fb47e46a426d5caeb62aad21f36348d4acd25af25b5e5ff5fbdbcb2f17d792ee3224a2916faf5ead7ee2aa93039fe672d0934d6db57179c2994d06db21fbeba87e86eae3f9f30b2f542ba98d72f0d33e0ee29b555a4b7ecb5596f573fcd23f864434e251f8cd72e0d3dcad4387aa55d4467d79fe7c710d990f8fc26f962fa5cd6453d63cad4ba3757de7cee23a323f8644cd2aad25bf9527bfaa5eb630e81f43221af108f2e639f0a92ffb4578aadee879f47dbb78147eb30cd59bf9e8f0e16a05b5511e7ddf4e8644cd2aad25bf958187ea95871695d692ee3224a231b7fe342b073e1e2559cf9d63c7aad5d32879f47dbbbcbb674ff59351ddee9e38515c53caf244bdfc8ed16879f47d3b191235abb496fc962d33ea6748d43f864434e696b3e6d9287374f9b268a3f4d1f3e8fbf6c9fe50ae846b5e3e034aebcae3f23afbfad2a56ad5344a1e7ddf4e8644cd2aad258fcb205df53324ea1f43221acbd50a6a5e6e0928ad2bbffae3d34f3bb8ae99fbc6db2957c4a859b925c86d671bcbadcc1a3d8fbe6f2f43a26695d692c7d9d4bf598644fd6348c45872458c9af59f870f6d98b98e9c15ffe6f2e56ab5346aaeba6827fbb88d57f6752aad2bbf7867f76e575cd6cc15bded6548d4acd25af2b82fce9dab564b753224ea1f4322c6e20901e3f56069c999cc35d858b07e1e7ddf6e79bfab79379f7fbeb8ae7d97ab7a3d41af7e1e7ddf5e8644cd2aad25bfca931ff33d49f5fbe4e4c9e29ad25d86448c25038e5c11a3e67d75f1a203fb27d8e8b759aeb668374f9d1aaf5c29b3f4dc73c5b5edabfceeb0096bb3ded8bebdb8a6cc9f2151b34a6bc9af3c04a5799eccdc3f86448ccde39dc72f97bf96d6b68ff2e43767c59b95e15a694d69875cf1e196a0f1ca59e0b79e7db6b8be7df4f1f1e3d5caa84edf5dbb565c4fdac190a859a5b5e417f96ee9a476f35c79d93f86448ccd551f93c9a39e7fb932edfbebd7ab15519d1edebe5d5c53dac5d3a7c62f9bd9bfb96347717dfbe4830307aa1551ddb2796d694d690743a26695d6925f2c5fb850ad929ae433b37f0c89185b2e77f704aac99441515f6f3dcbd38bdc36d13c97022f0607f69329bf73fabcf17f5e47ae4a6b56ae46b31760bb191235abb496fcb2b1bfc62bbf734a6b4b77191231117f7de9a5ea15a071fbf2fcf9de7d81cda3ee7fbc79b35a01d52d078bb995a9b4b6b44b86c0b9ea4be39783fd7cf92fad7397f97d3b5e9f9e3a555c57dac390a859a5b5ecbb5c75ea44f6f8e53d595a5fbacb908889c850e3e7fbf7ab5781c62dfb256470525aebaec9e6a10644e3955b984a6b4b3b39c89f5c1990e6299ba575eea2db478e547f7335eded5dbb8a6b4b7b181235abb4967de604e4e4f2d088fe3124626272bb8b2657ae36e8fae43e97af7a1ce9f8bdbf7f7f717d69a73c86d7507db2e5f1bc5dbe02f3b52d5bec6735817eb871a3b8beb48b2151b34a6bd957f9cc34209a5cd9f8bbb4ce74972111139389bd27074cbeec539483cad29a2faafc7d72c9bfc62f4f82ebeb3e568bcca378275f5707eb3983fbcfbb77abbfa5c62957f195d6987631246a56692dfbc81e9793af6bc7216ccc908889ca4043932f6743ba72897cae7ab127cbe4ca23b04beb4cbb19aa4fafae5c5594d7c867a74f577f2b8d5bde6fb9baa0b4d6b48b2151b34a6bd93737f6ee35549f70aec0ec274322262afbcb78e2caf4ca233cfff4cc33c5b56fbb6c1ef8cde5cbd5df4493caa3c01797abe9a657362acd55238b78f6335706e6cfee96c4c9f6c5b973c5f5a67d0c899a555acbbec800380f7ed1e4cbba96d69c6e332462e23e3f7bb67a35685a2dd2b028b74ae4178ce1e1e4cb06e7a535673164a8aee9b648c3a2dc22f1d1e1c3aeb49c52efeed9535c77dac790a859a5b5ec833fbff0c2f0d67b4da7bfbdfc7271dde9364322262ec30bcda6dc739d27fbe4e0a2f4b39897dcea915fdadf5fbf5efd49358db2c6a5f5677164e0abe997ab7272e5561b6fdbcdefccdc226713ffe995c15b69ed692743a26695d6b2abde7af6d9e116176e2d9b7eb985aff433a0db0c89988a7b67ce54af08cda2ecb5904be9dfdbb76f6e03a36b5bb70e3e3c7870784b99bd56a65f0e7abbfc34a7be708beeeccb1e6f39333aafab31733bd93bbb770f0f705c35349b6e1f3952fc59d04e8644cd2aad6597e4f7651efaf08f5bb7aabfb16651bedf977e1e749b211153910d379d159d5f0f9696860720191ae56751fa198d23073939c0ba75e8d07020e831a3b3efced1a3c59f0d8b279b8f6b3e65d89aabb9724b5a3ed3a6715b5af6cac867710e6e3244f7bb71b6e567dcb6ab6d599f2151b34a6bb988f2399ccfe30f0e1c18fe7efceae24503f53995cfcfd2cf88ee3324626a72e64eed2857f6e4e904f9459be1510e8872ab52649f867c217b520e6af29fe776b60c24320cca014e0642ae149a6f0e7aba253f4bfb29b4a7ec63945b79b3bf5e3efb563f2b73c052faac8cd5ff4ef614ca676cf661cb9e61f96769be19a82f9ebca754bf273f97da28b72ead7e5ee68acebc3f3340cf77cc0cec9d746c57f7af5c29be47e93e4322a62667024cfea5c9e7a0a77b72aba6a4c966a0be98324c9034ff72d2a3f41ea5fb0c8998aaf7f7efaf5e19922651ae4c58c4c77ab3bedcc299db44254dae5c355b7abfd16e8644523bcafe79a5f728dd6748c4d4e552454993c9414f77393092269781fae2f25928cdbfdc069f1358a5f728dd6748c4d465f3394fef91c6cf414ff7652f1b49e367a0beb80c89a4f9f7d9e9d3c5f727fd6048c44c7c72f264f50a91d4b46c225e7a7fd11daf6fdbe6e957d298e511d906ea8bcb90489a7f6e35eb37432266e2eaa64d36b196c628073d2efbed875b870e553f75494dca93934aef2d1683219134dfdc6a86211133e397bed43c073dfd622f37a95906ea8bcff74569beb9d50c432266ca6d6752fd7eb871c3414fcfb8ed4c6ad607070e14df532c0e432269beb9d50c432266ca6d6752fddedbb7aff87ea2dbdc7626d5ebc1d252f1bdc462312492e6975bcd08432266ce2f7f69f4beba78b1f83ea21fdc76268d569ea2faf6ae5dc5f7118bc5f744697edd3d71a2f8bea45f0c89980bb79d491bf7f3fdfb836b5bb716df43f483dbcea4d1faf8f8f1e27b88c5634824cda7ff3c7c38f8e3d34f17df97f48b21117391dbceb2b9a4a4b5b35935f1e1c183d52b4252a91f6fdef4c8fb0e312492e693ab88586548c4dc5cdfb9d31972698ddc66c6a3ee9d3953bd32243d9adbccbac790489a7dae22e2518644cc55ae9490f478d934f0b52d5b8aef19fa29575fe62977921ecf6d66dd634824cd3e5711f1284322e6eed353a7aa578fa4f4fefefdc5f70afdf6c6f6edaebe941ec96d66dd644824cd365711f1244322e62e5ff0bebf7ebd7a0549fdeecbf3e78bef13880c1025b9cdaccb0c89a4d9e62a229e6448442be4093e799293d4e7dc66c628f2654eea7b6e33eb2e43226976b98a881243225ae3dd3d7baa5791d4cf6eecdd5b7c6fc0a3fef0d453836faf5ead5e3552ff729b59b7191249b3ebefafbc527c1fd26f8644b4cadf5e7eb97a2549fd2a4faf2abd27a02467fd1edebe5dbd7aa4fee436b3ee3324926693813b6b3124a2756c64adbe95a756e5e955a5f703ace5cd1d3bdca6abde75ebd0a1e2fb81ee302492a69f813beb3124a275722bc5d7972e55af28a9dbfdebde3df782d3580ea6f2454fea439f9c3c597c1fd02d8644d2f4b3af1beb3124a2957255c583a5a5ea552575b33ccefc4fcf3c537c0fc0a86e3eff7cf58a92badbf2850bc39348a5f700dd6248244d37b799b11143225a2b5757e42a0ba98be5ea8f6cd65e7aed435d778e1ead5e5952f7fafefa75b7e4f688219134bddc66c6280c8968b55c6591ab2da4aef5e1c183c5d73c34f5f9d9b3d5ab4bea4ed9a0dd2db9fd6248244d2fb799310a43225a6fe9b9e70c8ad4a93c6e9469c8ad385f9e3f5fbdcaa4c52fbffbb3417be9f54e77191249d3290f4a719b19a3302462211814a92be520bef41a874930285257ca2d111916945ee7749b219134f93c28853a0c89581806455af4bebd7ad5191ca6cea0485de8cf2fbc507c7dd37d8644d264cbf1d3f59d3b8bef3728312462a118146951cb93249cc161560c8ab4c86523f6d2eb9a7e3024922657aeca7c67f7eee27b0dd66248c4c23128d2a26540c43c181469113320c290489a5caecaa40943221652be4018146911ca2d66af6ede5c7c1dc3b46550b47ce142f56a94da5bce767bea236148244d2643779a32246261e5deda7fdebd5bbdf2a4f69583f3ab9b36155fbf302b1914e591b7525bcb499ff7f7ef2fbe7ee91f432269fcee9d39537c7fc1280c895868b985e7fbebd7ab579fd49e3e3b7d7a78705e7addc23ce42a8d5cad21b5a99f969787b791975eb3f4932191345e9f9e3ae53b2863312462e1e54a0db753a84dfdfd95578aaf5598b777f7ec71abae5a53ae067e73c78ee26b95fe3224929af7b7975f2ebeafa00e43223ac1ed146a43b94ae3af2fbd547c8d425bb855576dc886feacc59048aadf7f1e3e74db2e13634844a764077f67c9358f3220f2cb99459183f36f2e5fae5ebdd26ccb86fef66b632d864452bdfe75ef9edb76992843223a2767c91f2c2d55af4869fafd7cfffef04b6de9f5086d952b306f1f39629f22cdb42fce9d1bfccfef7f5f7c4d42181249a397ab32ddb6cba41912d149f9029a4ddba469f7f5a54b836b5bb7165f87b00872f6d1ed679a76b9ca3757fb965e83f028432269b47245f06b5bb614df47300e43223aed830307dc7ea6a994d7d5ad43878aaf3b5834f9929981a7348d727bd9ebdbb6155f7bf024432269fd7c0765da0c89e8bc37b66f1f7c77ed5af50a95c62fafa7bcae4aaf3758641f1d3e3cdcfc529a44b99531af298f62a60e432269edee5fb962e8ced41912d11b1f1e3c38dc3b466a5a0e78b2878b031eba2c5f3e5d55a471fbe1c68dc19f9e79a6f81a83f5181249bfcdd543cc922111bd9227fa64d34ca96ed918d0010f7d92db75f3c414a96e1f1f3f6e736a1a3324921ecfd543cc9a2111bd7463efdec1c3dbb7ab57adb47e774f9c70c0432fbdba79f3e0b3d3a7ab7782b47ed9003d07f8a5d7128cca9048faa59ca8c99d10a5f7094c932111bd7575d3a6c19da347dd82a635cb999b3cf9a9f4fa813ec9fb20ef07a954f6b1ca303d43c5d2eb07ea302452dffbc7ad5bc3a7413a41c9bc1812d17bf9526b58a4477bb0b434786fdfbee2eb05fa2c076f86455a6d7538945bb94baf1768c290487d6df5fba7bd2f99374322a8181629676ededfbfbff8fa007e6558d4efb289ffbd33673ce591a93024529fca6dba19b6bb729d3631248227ac0e8b6cd8da9f562feb75e606eac9c19c27a1f52bc321a6cd90485defa7e5e5e17e7f79ad97de03306f8644b086dc079ca7fb7c77ed5af5ea56d7ca20f0af2fbd643804637a73c78ee19950576276b7e50b173ce19199302452d7caadb9df5ebd3af8fb2baf0cded9bddbf74e5acf900846902fc69f9e3a35fc90d7e29727db653864434098acbca7f22496ecaba0c52fb7957d79febce110336548a4452f570a65b0fed1e1c383b777edf27d938563480435e456b4bfbcf8e2e09bcb97875f9eb538fdfbc10397f6c20ce58b71ae2eca7e0b5aacbebf7e7d38487f6dcb96e2cf16a6c990488b52ae9ecde7656ec3fddbcb2f0f379d763b2e5d6048040de5cbb38151bbcbcf253f9f9bcf3fef2c0ecc5136e434306a77f9d97c7cfcf8e0face9dc59f21cc8a2191da54ee22f8f1e6cde1fe7b9f9c3c39b875e8d0f096314f75a4cb0c896002560746f905e296b4f9f7c38d1bc3333ad7b66e2dfebc80f9591d18e54bb7e65b7e5f7d7ef6ece0dd3d7bec91416b18126996e584621e60922776e68aa03cbc260f33c9ef2adf23e92b432298b05cb1922f38778e1d1b6e7aed2aa3d9944da87386e7ad679f2dfe5c80f6c917f07c19cfa0c2132567537e276503d59cd8b8ba6953f1e702f36448a449967d28f399f7c5b973c3ab25732bedfbfbf70f6f8936048232432298b2ec63947b9473e63cf72d1b1a4da65c85903d86728099272b95d61e582cb9d5295fe0b3e1a7a1d164ca7e6cb9ca3567c7738b84c1106d6748a4b5caef850c7d222762bfba78f1bf57ffe47747be13e673ce0008c663480433962b8d72b54b7e99e5ecb95b2e362eb744e4cb40ce0065e0663355e8877cc9cf7b3e8f0dcefe621eb1bf71d95b2867ccf33b264f25731b190050872111b440ae36ca9e10f9529f5ba672d6376749fa5ace14e54a82ec2b947bc26d3a0daccad5461f1c38303c739c6148aed0ecebf02803f4074b4bc3df1b5993d7b76d2bae1900c0a80c89a0c5321cc90151cea47f74f8f0f0f6aa5c5a9b83a245be152303b0ff6e1078ecd8706f8c5c1e9cc7861a08014de44933192ae7f324571de64acd7cce6443d2457da040865f190265689e41507e0f642f8d5c8deac93a00c0341812c182cb99e31c18e5c0215722e5ec7a864919c0e48aa41c24e5695f19cc646f8a49f6d3f2f27fef0dcf814cfe5d917f6ffefdf973dc3e7264f808fafc199de506e625576c66e89e8174f6adc867658649f9acca1549f9eccae6a6f93c9bf4a3fab317ddea6765ac7e5646feddf933e4cf92472bdfd8bb77f8e7cc9fb7f4f7000098264322e8a11c7c64605392614e368d7cd4a3ffb9fd2d803e79f4f3ef5119e43cf959993d8056ff737ba701008bc89008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c89000000003024020000006085211100000000864400000000181201000000b0c29008000000004322000000000c89000000005861480400000080211100000000864400000000ac302402000000c090080000000043220000000056181201000000604804000000802111000000002b0c8900000000302402000000c090080000008015864400000000181201000000604804000000c00a4322000000000c890000000030240200000060c5d48644000000002c9e51322402000000e8b8511a6948244992244992a46e67482449922449922443224992244992241912499224499224692543224992244992241912499224499224c990489224499224492b1912499224499224f5bec1e0ff07b24ee50f70a027130000000049454e44ae426082");
            Name = "CCB";
            Summary = 21080m;
        }

        #endregion
    }
}