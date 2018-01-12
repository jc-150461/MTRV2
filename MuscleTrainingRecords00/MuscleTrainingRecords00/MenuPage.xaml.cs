﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00.TrainingDatabase;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList;
            itemList = await itemDataBase.GetItemsAsync();

            if (itemList.Count < 1)
            {
                await storeInitialData(itemDataBase);
                itemList = await itemDataBase.GetItemsAsync();
            }

            // ListViewを生成する
            listView.ItemsSource = itemList;
        }

        private static async Task storeInitialData(TrainingDatabase itemDataBase)
        {
            Training pushup = new Training() { Menu = "アブドミナルマシンクランチ（マシン）", Load = "負荷度:☆☆", parts = "腹", Desc = "両脚は肩幅程度に開き、マシンのステップに足を乗せます。おへそを覗き込むように上体を丸めていく。（１０回ギリギリできるくらいのウェイトにセットして行いましょう" };
            await itemDataBase.InsertItemAsync(pushup);
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ウェィテッドクランチ（プレート）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "プレートを頭の後ろに抱え、膝を曲げ首から上がベンチから出るように仰向けに寝ます。腹筋を意識しながら状態を丸めます。腹筋の緊張を解かないままゆっくり上体がつくまでおろす" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "サイドバイク（ダンベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "ダンベルを片手に持ち、反対の手を頭の横に沿え・ダンベルの方向に体を預けて構える。ダンベルと反対側に体を傾けてもとに戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルクランチ（ダンベル）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "膝を９０度に曲げダンベルを頭の後ろあたりに置き、ダンベルを両手で掴み頭と一緒に持ち上げる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハンギングレッグレイズ（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "鉄棒などにぶら下がり、両足を９０度程度まで持ち上げゆっくりと下げる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーティカルベンチレッグレイズ（バーベル）　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "床にバーベルを置く、バーベルを両手でつかみ腕立て伏せのような姿勢をとり、バーベルのプレートを転がしながら腕を前に出して、状態が地面と平行になるぐらいまで倒して元に戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プルアップニーレイズ（マシン）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "ディップマシンのパットに背中をしっかり固定し、肩に力を入れて体を浮かせて腕とひじも固定しましょう。腹筋に力を入れながらゆっくり膝を上にあげます。９０度まで上げたら少しキープ、キープしたらゆっくり膝を下げていきます。（足を下げるとき完全に下げずに行うとより負荷をかけられます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールクランチ（ボール）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "両手を胸の前でクロスさせて状態を起こす。（上級者は両手を上げばんざいした状態でやることでより強い負荷をかけられる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールバイク（ボール）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "ボールに足をのせて腕立て伏せの状態をとる。脚とつま先を使って胸の方向に引き寄せる。（お尻を上に突き上げるように上げて２～３秒キープする" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "メディシンボールロシアンツイスト（ボール）　　　　　　", Load = "負荷度:☆☆", parts = "腹", Desc = "上半身が太ももとV字になるように起こす。腕が床と平行になるぐらいまで、体幹を片側へ捻っていきます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "TRX　ニータック（ボール）　　　　　　　　　　　　　　 ", Load = "負荷度:☆☆", parts = "腹", Desc = "腕立て伏せの姿勢から両脛をバランスボールに乗せセットします。そして膝を曲げ奈良がボールを手前に引き寄せます。その時膝を曲げながら少しずつ背中を丸めていきます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アームカール（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "クローズスタンスで両足をくっつけた状態で立ちます。バーベルをアンダーグリップ（手の平が上を向いた状態）で握る。そこから状態を前後に振ることで自然な反動を利用し振り上げるようにして、バーベルを肩もしくは顎の高さまで持ってきてキープします。（約20秒キープできるくらいの重量）" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクラインダンベルカール（ダンベル）　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "両手にダンベルを持ち、インクラインベンチに座ります。角度は３０度くらいにしてください。両手をぶら下げ肩の力を抜く、肘の位置を変えずに、上腕二頭筋を意識して腕をカールさせる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクランダンベルフライ（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "インクラインベンチにあおむけに寝る。手の平が向かい合うようにダンベルを持ち、ベンチ台に仰向けに寝ます。肩甲骨を寄せ、肘を軽く曲げた状態をキープしながらゆっくりとダンベルを胸が開くように下す。胸が張るくらい落としたら、そのままゆっくりと元の位置に戻す。（トップでダンベルをぶつけないように注意する）" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ケーブルプレス（マシン）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "足を肩幅程度に開き少し前傾姿勢になる。上腕三頭筋を意識し肘を固定したまま腕を下す。同じ軌道でゆっくりと繰り返す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "コンセントレーションカール（ダンベル）　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "片手にダンベルを持ち、両足を開いてベンチに座ります。スタートポジションは、ダンベルを持っているほうの肘を同じ側の膝の内側に固定し、逆脚にもう一方の手を置いて固定します。肘を曲げてダンベルを高く持ち上げてもとに戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルベンチブレス（ダンベル）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "ダンベルを両手で持ってベンチ台に仰向けで寝る。両手を伸ばしてダンベルを横向きにして胸の上くらいにポジションを取る。ゆっくりと肘を曲げて胸の横くらいにダンベルが触れる程度までおろしていく。大胸筋が十分伸びたのを確認したら再度持ち上げる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "トライセプスキックバック　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "ダンベルを片手に持ち、もう一方の手とビザをベンチに乗せてうつぶせになる。ダンベルをもっている側の肘を曲げて上腕部分が地面と平行になるようにする。肘の位置を固定したまま肘を伸ばして、ダンベルを後ろ側に持ち上げてもとに戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ナロウベンチブレス（バーベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "ベンチに仰向けになり脚はしっかりと床につけます。バーを肩幅より狭く握り、親指は握りこまないようにする。肘を体につけるようにバーをおろしていき、胸の下部にバーが触れる直前までおろす" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プリーチャーカール　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕", Desc = "上腕部をパットに乗せて軽く肘を曲げる、アンダーグリップでバーベルを握る。手首は曲げずにまっすぐ伸ばす。固定した上腕部は動かさず、バーベルを高く巻き上げ、上腕二頭筋にかかっている負荷を解かないようにバーベルを下げる。巻き上げるときに息を吐き、おろすときに息を吸う" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ライイング　トライセプス　エクステンション（バーベル）", Load = "負荷度:☆☆", parts = "腕", Desc = "仰向けになった状態でイージーバーを持つ、両手を平行に保ち脇を絞りながら持ち上げる。同じ軌道でゆっくりと戻す。上げ方のバリエーションを変えながらしっかりと効かせる" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "懸垂（マシン）　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "懸垂用のバーにぶら下がります。この時足を後ろで組み、気持ち胴体を後ろへ持ってくる動作中に体がぶれにくくなります。できる限り体を引き上げていくようにします。できるだけ胸がバーに着くか顎がバーをこすようにあげましょう" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "シーテッドローイング　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "マシンに胸を起こした状態で座りプレートに両脚を置く。軽くバーを引いて背中を真っすぐにして、肩甲骨を意識しながらバーをさらに引く息を吸い込みながらゆっくりと戻していく" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "スペインヒップリフト　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "床に仰向けに寝て膝を曲げた状態で足裏は床につける。その状態からお尻を持ち上げ（勢い良く持ち上げると腰を痛めることがあるので注意）、床に着くぎりぎりまでゆっくりお尻を降ろす" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルアップライトロー（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "肘を軽く曲げた状態でダンベルを太ももの前におろしておく。背中を真っすぐにダンベルがまっすぐ上に上がると同時に肘を曲げていきます。ダンベルが顎に着くぎりぎりまで上げましょう" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルロウ　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "状態は動かさず、肩甲骨を大きく動かす。背中をアーチさせ、胸を張って肩甲骨を寄せやすくする。動作は反動をつけず、ダンベルを下す際もゆっくりと行う" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "デッドリフト　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "バーベルの重さを調整する際重すぎないようにする（腰を痛めたりするため）。バーベルを握る幅は足幅より少し広いくらいにする。足は肩幅程度に開く。背中を丸めないように胸を張って膝を曲げながらおしりを突き出すようにする。バーベルは足の真ん中くらいから持ち上げるようにする。肩甲骨を引き寄せるイメージでアーチを描くように上体を起こしていく" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントオーバーロウ　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "肩幅くらいに両脚を開いて立ち、膝を軽く曲げる。背部を伸ばしたまま状態を股関節から曲げる。肩幅よりやや広めにバーベルを握り、息を吐きながら、肘を曲げておなかに向かってバーベルを引く" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バックエクステンション　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "バックエクステンションの器具に足を置き太ももパッドにあてる。背中を直線状にし、腕を胸の前あたりで組んで前方に体を倒す。倒す角度は９０度程度まで倒し元の状態に戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ラットブルダウン　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "ウェイトをセットし、椅子に座ります。高さを調節できるタイプであればしっかりと太ももを固定します。バーを両手で握り、握る幅は肩幅の１．５倍程度にしましょう。背筋を伸ばして、バーを鎖骨のあたりに向かっておろしていきます。広背筋で引いてくるイメージを持つことが重要です。鎖骨の高さまで引いたらゆっくりと戻していきます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ワンハンドローイング（ダンベル）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中", Desc = "片足と片手をベンチにしっかりと乗せ、腰から首までを丸めず胸を張り顔は下ではなく斜め前を向く。まずしっかりとフォームを作り、ダンベルをもってスタンバイダンベルを横腹まで引き上げる。ゆっくりとおろす" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アーノルドブレス（ダンベル）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "鎖骨の前あたりに逆手でダンベルを持って立つ、ダンベルを内にひねりながら頭上に持ち上げる。逆方向にひねって戻し元の位置までゆっくり下す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクラインベンチプレス（バーベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "ベンチ台の角度を３０度くらいに調整します（調整できないものもあります）。ベンチに座って両手でバーを順手で持ちます。バーベルを持ち鎖骨くらいまで落とします。これを繰り返す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ケーブルクロスオーバー（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "日本のケーブルのバーを両手に持ち、肘を少し曲げた状態で胸を開き、腕をやや後方で構えます。バーをお腹の前辺りまで引き付けてもとに戻します" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルアップライトロウ（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "ダンベルを両手で持ち、肘から上げるように持ちあげる。ダンベルが顎に着くくらいまで上がったらゆっくりと元に戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルフライ（ダンベル）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "ダンベルを胸の上に持ち、ベンチに仰向けになります。ダンベル同士が平行になるように、腕を伸ばし構えます。肩甲骨を寄せるようにして、両腕を開きます。大胸筋の収縮を意識しながら、両腕を戻します" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "チェストブレス（マシン）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "肩甲骨を寄せて胸を張りましょう。大胸筋を意識して一気に押して出していきます。そのあと息を吐きながらゆっくり戻します" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ディップス（自重）　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "平行棒に腕を立てて、体を支え、腕を伸ばしておきます。足を後ろでクロスさせて上半身を少し前のめりにします。ゆっくりと肘を曲げて、肘が９０度になる程度まで体を深くおろしていきます。その後肘を伸ばしていき元の位置に戻ります" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ブルオーバー　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "ラットベンチのシドから仰向けに寝る、膝を曲げて足は床につけ安定させる。ダンベル一戸のプレート部分に両手をひっかけて持ち、肘を伸ばしダンベルを顔の真上に持ってくる。両手を伸ばしたままダンベルを頭の後方まで下げてもとに戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ペッグデックフライ（マシン）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "マシンにお尻と背中を密着させて座ります。両手でグリップを握る時に肘の角度は９０度になるようにしましょう。両肘を合わせるようにというイメージで胸の筋肉を収縮させます。その姿勢で１～２秒間キープして戻します" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベンチプレス（バーベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩", Desc = "ベンチに仰向けに寝転がり方を下に下げて肩甲骨を寄せて胸を張る。足の裏をしっかり床につけ肩幅より広めに両腕を開いてバーベルを握ります。ラックからバーベルを外したらゆっくり胸に着くくらいまで下げます。元の位置まで戻します" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "カーフレイズ（自重）　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "足首が上下できる台に立ちます。体がぶれないように、壁や手すりなどに手をつきつま先立ちになります。背筋を伸ばしたまま、ゆっくりとかかとを上げていきます。その後ゆっくりふくらはぎの筋肉を意識しながらかかとを下ろしていきましょう" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルスクワット（ダンベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "手の平が自分のほうを向くようにダンベルを握ります。両足は肩幅程度に広げて、つま先は気持ち外側を向くようにします。太ももが床と平行になるまでを目安にしゃがみます。かかとに重心を置き、床を踏み込むようにしながら力を出していきましょう" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハックスクワット（マシン）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "両肩を肩パッドの下に位置させるように固定し、両足を肩幅程度に開き、プラットフォームに置きます。両足の指先は、軽く外側を向くようにしておきます膝の角度９０度より少し下回るくらいまで下げます。立ち上がった時、膝は完全に伸び切らないようにしましょう。" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハックリフト（バーベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "床に重さを調整したバーベルを置き前に立ちます。しゃがんでバーベルを握ります。背筋はまっすぐのままひざを曲げて握り、反動をつけずにそのまま立ち上げります" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーベルスクワット（バーベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "パワーラックにバーベルをセットし、両手でバーベルを握る。首のつけ根付近にバーベルを載せ、ラックからバーベルを外します。両足は肩幅程度に開き、背筋を伸ばす。太ももが水平になるまで両ひざを曲げて腰を落とす。膝を伸ばして元の状態に戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーベルランジ（バーベル）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "バーベルを担いだ状態で立ち、片足を前に踏み出し、腰を深くおろす（腰を下ろす時重心を真ん中に置き背中を丸めないようにする）。足を元の位置に戻す" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ルーマニアンデッドリフト（バーベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "床に置いたバーベルを両手で握ります。足は肩幅くらいまで開きデッドリフトの要領で腰まで持ち上げます。胸を張った乗田で膝を曲げずにバーベルを下ろします（胸を張り背中を丸めないように行います。）ハムストリングがストレッチされるのがわかると思いますので、そのストレッチが限界のところまで下げます。限界まで下げたら再度持ち上げます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグエクステンション（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "マシンに座りサイドレバーでシートの位置を調節します。膝の裏側にバッドが当たる位置に合わせたら、足首を足首パッドにかけます。ウェイトを調節。最初は軽い重量から始める。ウェイトを上げるときは息を吐きながら一気に上げる。伸ばし切ったところでぐっと止めて我慢してみるのも効果が高いです。ウェイトをおろして来るときは息を吸いながらゆっくりとおろしましょう。一気におろすと効果が薄れます" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグカール（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "足に当たる部分のパッドの位置を調節する。ふくらはぎの下部から足首にかけてあたるようにする。マシンに寝そべった状態でレバーを握り、足を延ばした状態でゆっくりと膝を曲げていくしっかりと膝を曲げてもとに戻していく。呼吸は膝を曲げるときに吐き、戻すときに吸う" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグプレス（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚", Desc = "シートの角度を調節します。シートに座ってプレートに両脚を置く。膝を伸ばしてストッパーを外し、膝をゆっくり曲げます。お腹に膝がつく蔵院で曲げたら持ち上げます" });
        }

        //SearchBarを押した時のイベントハンドラ
        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            /*TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts(Select.Text);
            listView.ItemsSource = itemList;*/

            /*if (0<=Select.Text.IndexOf(array1))
            {   
            }
            else
            {
                this.listView.ItemsSource = "データがありません";
            }*/

        }

        private async void 全部_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsync();
            listView.ItemsSource = itemList;

        }

        private async void 腹_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腹");

            listView.ItemsSource = itemList;
        }

        private async void 腕_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腕");

            listView.ItemsSource = itemList;

        }

        private async void 背中_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("背中");
            listView.ItemsSource = itemList;
        }

        private async void 胸肩_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("胸肩");
            listView.ItemsSource = itemList;
        }


        private async void 脚_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("脚");
            listView.ItemsSource = itemList;
        }



        private void Sort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //int s = Sort.SelectedIndex;
            String si = (String)Sort.SelectedItem;
            //if (si==0)
            if (si.Equals("負荷度順"))
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
            else
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            // DisplayAlert("", , "OK");

            Training training = (Training)listView.SelectedItem;
            String l = training.Menu;
            //String m = training.Desc;

            //Navigation.PushAsync(new MenudetaliPage(l));

            Navigation.PushAsync(new MenudetaliPage(l, m));
        }
    }
}