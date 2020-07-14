using System.Windows.Forms;
using System.Drawing;

namespace BusSystem
{
    public partial class Route : Form
    {
        static int count;
        string[] nationwide = { "강릉", "강진", "경북도청", "경주", "고대조치원", "고양백석",
        "고양화정", "고창", "고흥", "공주", "광명(KTX역)", "광명(철산역)", "광양", "광주",
        "구례", "구리", "구미", "군산", "금산", "김제", "김천", "김천혁신", "김해", "김해장유",
        "나주", "낙동강상행", "낙동강하행", "남악", "남원", "내포", "늑동", "논산", "능주",
        "담양", "당진", "당진기지시", "대구용계", "대구혁신", "대전도룡", "대전복합", "대전청사",
        "덕과", "덕산스파", "동광양", "동대구", "동서울", "동해", "마산", "마산내서", "목포",
        "무안", "문장", "밀양", "배방정류소", "벌교", "보성", "부산", "부천", "북청주", "삼척",
        "삼호", "상봉", "상주", "서대구", "서부산(사상)", "서산", "서수원", "서울경부", "선문대",
        "선산(휴)상행", "선산(휴)하행", "섬진강(휴)상행", "섬진강(휴)하행", "성남(분당)", "세종국무조정실",
        "세종시", "세종시청", "세종연구단지", "세종청사", "센트럴시티", "속초", "수원", "순창", "순천",
        "순천신대지구", "시흥", "신갈시외", "신갈영덕", "아산둔포", "아산서부", "아산온양", "아산탕정사무소",
        "아산테크노벨리", "안동", "안면도", "안산", "안성", "안성공도", "안성대림", "안성중대", "안성풍림",
        "안성한경", "안성회관", "안중", "안중오거리", "애통리", "양산", "양양", "여수", "여주", "여주대",
        "여천", "연무대", "영광", "영덕", "영산포", "영암", "영주", "영천", "영천망정동", "영통", "예산",
        "예천", "오산", "완도", "용인", "용인신갈", "용인유림", "울산", "울산신복", "원동", "원주", "원주문막",
        "원주혁신", "유성", "의정부", "이천", "이천(마장택지지구", "이천부발", "익산", "익산팔봉", "인삼랜드상행",
        "인삼랜드하행", "인천", "인천공항T1", "인천공항T2", "wkcldlswodnjs", "장성", "장흥", "전북혁신",
        "전주", "전주호남제일문", "점촌", "정산", "정안상행", "정안하행", "정읍","제천", "제천하소", "조치원",
        "죽전", "중앙탑면", "지도", "진도", "진주", "진주개양", "진주혁신" ,"진해", "창기리" ,"창원", "창원역",
        "천안", "천안3공단", "천안아산역", "청양", "청주", "청주고속터미널", "청주공항", "춘천", "충주",
        "탕정삼성LCD", "태안", "태인", "통영", "평택", "평택대", "평택용이동", "포항", "포항시청", "풍기", "함평",
        "해남", "해제", "홍대조치원", "홍성", "화순", "황간", "회진", "횡성상행", "횡성하행"};
        string[] seoul = { "동서울", "상봉", "서울경부", "센트럴시티" };
        string[] ingeoug = {"고양백석", "고양화정", "광명(KTX역)", "광명(철산역)", "구리", "부천", "서수원", "성남",
        "수원", "시흥", "신갈시외", "신갈영덕", "안산", "안성", "안성공도", "안성대림", "안성중대", "안성풍림", "한성한경",
        "안성회관", "안중", "안중오거리", "여주", "여주대", "영통", "오산", "용인", "용인신갈", "용인유림", "의정부",
        "이천", "이천(마장택지지구)", "이천부발(신하리)", "인천", "인천공항T1", "인천공항T2", "죽전", "평택", "평택대","평택용이동" };
        string[] gangwon = { "강릉", "동해", "삼척", "속초", "양양", "원주", "원주문막", "원주혁신", "춘천", "횡성상행", "횡성하행" };
        string[] daenam = {"고대조치원", "공주", "금산", "내포", "논산", "당진", "당진기지시", "대전도룡", "대전복합", "대전청사",
        "덕산스파", "배방정류소", "서산", "선문대", "세종국무조정실", "세종시", "세종시청", "세종연구단지", "세종청사", "아산둔포",
        "아산서부", "아산온양", "아산탕정사무소", "아산테크노밸리", "안면도", "연무대", "예산", "유성", "인삼랜드상행", "인삼랜드하행",
        "조치원", "창기리", "천안", "천안3공단", "천안아산역", "청양", "탕정삼성LCD", "태안", "홍대조치원", "홍성" };
        string[] chungbuck = { "북청주", "제천", "제천하소", "중앙탑면", "청주", "청주고속터미널", "청주공항", "충주", "황간" };
        string[] ghangnam = { "강진", "고흥", "광양", "광주", "구례", "나주", "남악", "녹동", "능주", "담양", "동광양", "목포",
        "무안", "문장", "벌교", "보성", "삼호", "섬진강상행", "섬진강하행", "순천", "순천신대지구", "여수", "여천", "영광", "영산포",
        "영암", "완도" ,"장성", "장흥", "지도", "진도", "함평", "해남", "해제", "화순", "회진"};
        string[] junbuck = {"고창", "군산", "김제", "남원", "덕과", "순창", "애통리", "익산" ,"익산팔봉", "자치인재원", "전북혁신",
        "전주", "전주호남제일문", "정읍" ,"태인" };
        string[] busan = {"김해", "김해장유", "마산", "마산내서", "밀양", "부산", "서부산", "양산", "울산", "울산신복", "원동", "진주",
        "진주개양", "진주혁신" ,"진해", "창원", "창원역", "통영" };
        string[] daegu = {"경북도청" ,"경주", "구미", "김천", "김천혁신", "낙동강상행", "낙동강하행", "대구용계", "대구혁신", "동대구",
        "상주", "서대구", "선산상행", "선산하행", "안동" ,"영덕", "영주" ,"영천", "영천망정동", "예천", "점촌", "포항", "포항시청", "풍기" };


        public Route()
        {
            InitializeComponent();
            update_listbox(nationwide);
            count = 0;
        }

        // 리스트박스 업데이트
        private void update_listbox(string[] city_name)
        {
            listBox1.Items.Clear();
            foreach (string city in city_name)
                listBox1.Items.Add(city);
        }

        // 도시 선택
        private void select_city(string city, int count)
        {
            if (count == 0)
            {
                start_point.Text = city;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.Linen;
            }
            else
            {
                arrive_point.Text = city;
                DialogResult = DialogResult.OK;
            }
        }

        // 전국
        private void button1_Click(object sender, System.EventArgs e)
        {
            update_listbox(nationwide); 
        }

        //서울
        private void button2_Click(object sender, System.EventArgs e)
        {
            update_listbox(seoul);
        }

        // 인천/경기
        private void button3_Click(object sender, System.EventArgs e)
        {
            update_listbox(ingeoug);
        }

        // 강원
        private void button4_Click(object sender, System.EventArgs e)
        {
            update_listbox(gangwon);
        }

        // 대전/충남
        private void button5_Click(object sender, System.EventArgs e)
        {
            update_listbox(daenam);
        }

        // 충북
        private void button6_Click(object sender, System.EventArgs e)
        {
            update_listbox(chungbuck);
        }

        // 광주/전남
        private void button7_Click(object sender, System.EventArgs e)
        {
            update_listbox(ghangnam);
        }

        // 전북
        private void button8_Click(object sender, System.EventArgs e)
        {
            update_listbox(junbuck);
        }

        // 부산/경남
        private void button9_Click(object sender, System.EventArgs e)
        {
            update_listbox(busan);
        }

        // 대구/경북
        private void button10_Click(object sender, System.EventArgs e)
        {
            update_listbox(daegu);
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            string search_city = textBox1.Text;
            foreach (string city in nationwide)
                if (search_city.Equals(city))
                {
                    select_city(search_city, count++);
                    return;
                }
            MessageBox.Show(search_city + " 검색 결과가 없습니다.");
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            select_city(listBox1.SelectedItem.ToString(), count++);
        }

        public string getStartPoint
        {
            get { return start_point.Text; }
        }

        public string getArrivePoint
        {
            get { return arrive_point.Text; }
        }
    }
}
