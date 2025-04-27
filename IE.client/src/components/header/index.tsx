import { useContext } from 'react';
import { Layout, Menu, Avatar } from 'antd';
import { UserOutlined } from '@ant-design/icons';
import styles from './style.module.scss';
import { Link } from 'react-router-dom';
import { AppContext } from '../../contexts/appContext';

const { Header } = Layout;

const AppHeader = () => {
    const { state } = useContext(AppContext);
    return (
        <Header className={styles.header}>
            <div className={styles.left}>
                <div className={styles.logo}>MyApp</div>
                <Menu theme="dark" mode="horizontal" selectedKeys={[state.menyKey]}> 
                    <Menu.Item key="1">
                        <span>Home</span>
                        <Link to="/"/>
                    </Menu.Item>
                    <Menu.Item key="2">
                        <span>About</span>
                        <Link to="/about"/>
                    </Menu.Item>
                    <Menu.Item key="3">
                        <span>Page</span>
                        <Link to="/page"/>
                    </Menu.Item>
                </Menu>
            </div>
            {state.loading && <div className={styles.right}>
                <Avatar icon={<UserOutlined />} />
                {state.userInfo?.name}
            </div>}
        </Header>
    );
};

export default AppHeader;
