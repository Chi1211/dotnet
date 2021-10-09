using System.Collections.Generic;
using aspmvc_hello.Models;
namespace aspmvc_hello.Service{
    public class PlanetService{

        public List<PlanetModel> planet=new List<PlanetModel>(){
            new PlanetModel(){id=1, name="Mercury", vnName="Sao Thủy", 
            desciption=@"Sao Thủy (cách Mặt Trời khoảng 0,4 AU) là hành tinh gần Mặt Trời nhất và 
            là hành tinh nhỏ nhất trong Hệ Mặt Trời (0,055 lần khối lượng Trái Đất). Sao Thủy không 
            có vệ tinh tự nhiên, và nó chỉ có các đặc trưng địa chất bên cạnh các hố va chạm đó là các 
            sườn và vách núi, có lẽ được hình thành trong giai đoạn co lại đầu tiên trong lịch sử của
            nó. Sao Thủy hầu như không có khí quyển do các nguyên tử trong bầu khí quyển của nó đã bị 
            gió Mặt Trời thổi bay ra ngoài không gian.", 
            urlImage="~/img/planet/SaoThuy.jpg"},
            new PlanetModel(){id=2, name="Venus", vnName="Sao Kim", desciption=@"Sao Kim (cách Mặt Trời khoảng 
            0,7 AU) có kích cỡ khá gần với kích thước Trái Đất (với khối lượng bằng 0,815 lần khối lượng 
            Trái Đất) và đặc điểm cấu tạo giống Trái Đất, nó có 1 lớp phủ silicat dày bao quanh 1 lõi sắt. 
            Sao Kim có 1 bầu khí quyển dày và có những chứng cứ cho thấy hành tinh này còn sự hoạt động của 
            địa chất bên trong nó. Tuy nhiên, Sao Kim khô hơn Trái Đất rất nhiều và mật độ bầu khí quyển của 
            nó gấp 90 lần mật độ bầu khí quyển của Trái Đất.", 
            urlImage="~/img/planet/SaoKim.jpg"},
            new PlanetModel(){id=2, name="Earth", vnName="Trái Đất", desciption=@"Trái Đất (cách Mặt Trời 
            1 AU) là hành tinh lớn nhất và có mật độ lớn nhất trong số các hành tinh vòng trong, cũng là hành 
            tinh duy nhất mà chúng ta biết còn có các hoạt động địa chất gần đây, và là hành tinh duy nhất 
            trong vũ trụ được biết đến là nơi có sự sống tồn tại", 
            urlImage="~/img/planet/TraiDat.jpg"},
            new PlanetModel(){id=3, name="Mars", vnName="Sao Hỏa", desciption=@"Sao Hỏa (cách Mặt Trời khoảng 1,5 AU) 
            có kích thước nhỏ hơn Trái Đất và Sao Kim (khối lượng bằng 0,107 lần khối lượng Trái Đất).", 
            urlImage="~/img/planet/SaoHoa.jpg"},
            new PlanetModel(){id=4, name="Jupiter", vnName="Sao Mộc", desciption=@"Sao Mộc (khoảng cách đến 
            Mặt Trời 5,2 AU), với khối lượng bằng 318 lần khối lượng Trái Đất và bằng 2,5 lần tổng khối 
            lượng của 7 hành tinh còn lại trong Thái Dương Hệ", 
            urlImage="~/img/planet/Moc.jpg"},
            new PlanetModel(){id=5, name="Saturn", vnName="Sao Thổ", desciption=@"Sao Thổ 
            (khoảng cách đến Mặt Trời 9,5 AU), có đặc trưng khác biệt rõ rệt đó là hệ vành đai kích thước rất lớn", 
            urlImage="~/img/planet/Tho.jpg"},
            new PlanetModel(){id=6, name="Uranus", vnName="sao Thiên Vương", desciption=@"Sao Thiên Vương (khoảng 
            cách đến Mặt Trời 19,6 AU), khối lượng bằng 14 lần khối lượng Trái Đất, là hành tinh vòng ngoài nhẹ 
            nhất", 
            urlImage="~/img/planet/ThienVuong.jpg"},
            new PlanetModel(){id=7, name="Neptune", vnName="Sao Hải Vương", desciption=@"Sao Hải Vương (khoảng 
            cách đến Mặt Trời 30 AU), mặc dù kích cỡ hơi nhỏ hơn Sao Thiên Vương nhưng khối lượng của nó lại lớn hơn", 
            urlImage="~/img/planet/HaiVuong.jpg"}

        };
    }
}