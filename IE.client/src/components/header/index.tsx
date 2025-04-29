import { Layout, Menu, Avatar } from 'antd';
import { UserOutlined } from '@ant-design/icons';
import styles from './style.module.scss';
import { Link } from 'react-router-dom';
import { useSelector } from 'react-redux';
import { RootState } from '../../store';

const { Header } = Layout;

const AppHeader = () => {
    const userState = useSelector((state: RootState) => state.user);
    const menuState = useSelector((state: RootState) => state.menu);
    return (
        <Header className={styles.header}>
            <div className={styles.left}>
                <div className={styles.logo}>MyApp</div>
                <Menu theme="dark" mode="horizontal" selectedKeys={[menuState.menyKey]}> 
                    <Menu.Item key="1">
                        <span>Home</span>
                        <Link to="/"/>
                    </Menu.Item>
                    <Menu.Item key="2">
                        <span>Page</span>
                        <Link to="/page"/>
                    </Menu.Item>
                    <Menu.Item key="3">
                        <span>About</span>
                        <Link to="/about"/>
                    </Menu.Item>
                </Menu>
            </div>
            {userState.loading && <div className={styles.right}>
                <Avatar icon={<UserOutlined />} />
                {userState?.user.name}
            </div>}
        </Header>
    );
};

export default AppHeader;
