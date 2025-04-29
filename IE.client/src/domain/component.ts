import { ComponentTypes } from "../utils/enums"
import { cssStringToObject } from "../utils/functions"

export interface Component {
    id: string,
    name: string,
    type: number,
    content: string,
    style?: React.CSSProperties,
    data: any
}

export const mockComponents: Component[] = [
    {
        id: '1',
        name: 'slider',
        type: ComponentTypes.SliderImage,
        content: '',
        style: cssStringToObject('height: 450px;width: 550px;'),
        data: [
            {
                id: '',
                src: 'https://nguondiaoc.net/pl/img/40/lang-bien-phuoc-tinh.jpg',
                style: cssStringToObject('height: 450px;width: 550px;'),
            },
            {
                id: '',
                src: 'https://nguondiaoc.net/pl/img/40/lang-bien-phuoc-tinh-2.jpg',
                style: cssStringToObject('height: 450px;width: 550px;'),
            },
            {
                id: '',
                src: 'https://cdn3.ivivu.com/2024/07/lang-chai-phuoc-tinh-ivivu-8.jpg',
                style: cssStringToObject('height: 450px;width: 550px;'),
            },
            {
                id: '',
                src: 'https://cdn3.ivivu.com/2024/07/lang-chai-phuoc-tinh-ivivu-2.jpg',
                style: cssStringToObject('height: 450px;width: 550px;'),
            }
        ]
    },
    {
        id: '2',
        name: 'title',
        type: ComponentTypes.Title,
        content: 'Làng chài Phước Tỉnh',
        data: ''
    },
    {
        id: '3',
        name: 'subTitle',
        type: ComponentTypes.SubTitle,
        content: 'Phước Tỉnh là một xã thuộc huyện Long Đất, tỉnh Bà Rịa – Vũng Tàu, Việt Nam.',
        data: ''
    },
    {
        id: '4',
        name: 'subTitle',
        type: ComponentTypes.Description,
        content: `Thuộc huyện Long Điền, Bà Rịa – Vũng Tàu, làng chài Phước Tỉnh vô cùng sầm uất với tuổi đời hơn 300 năm. Đời sống của nhiều người dân làng chài đã trở nên khấm khá. 
                                Thu nhập bình quân đầu người ở đây hiện đang ở mức 2.500 USD/năm. 
                                Đây là con số cao so với nhiều nơi khác. 
                                Được gọi là “làng tỷ phú”, bởi ở làng cá này có rất nhiều ngư dân đang sở hữu
                                 những cặp tàu có giá trị lên đến hàng chục tỷ đồng.
                                 Bên cạnh nghề đánh cá, Phước Tỉnh còn làm giàu từ nghề đóng tàu. 
                                 Làng này có 5 ụ đóng tàu, thu hút hàng trăm thợ lành nghề và rất 
                                 nhiều lao động địa phương. Hàng năm, làng chài cho hạ thủy hơn 40 
                                 chiếc tàu đánh bắt xa bờ. Ngoài khả năng đóng mới, Phước Tỉnh cũng 
                                 là nơi rất có uy tín trong việc sửa chữa tàu biển. 
                                 Nhiều tàu ở nơi khác cũng thường đến đây để sửa tàu của mình.`,
        data: ''
    }
]