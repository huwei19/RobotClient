-------------------------------------------------
������ɲ����ļ�?
1. �༭��ǰĿ¼�µĲ��������ļ�   Main\Server\Robot\deploylist.txt����ʹ��excel�༭��
2.ִ�� make_deploy.cmd
3.ִ�� deploymaker\DeployMaker.exe
4.���ɵ�shell�ű�����\deployĿ¼��
-------------------------------------------------
ע������
RobotClient��Ŀ��
1. ʹ��vs2019����
2. vs��debugģʽ��Ĭ������������в��������Ե�ʱ��ȷ����ȷ����
-batch 1 -robotIdx 8000000 -serverId 107 -aiType 14 -robotNum 10 -isLog True -initId 1 -ExeCDTime 1 -arg0 15000 -arg1 10 -arg2 0
3. vs���·���� Main\Server\Robot\
3. ������Ҫ����table�ļ���Ŀǰ�ǽ�table�ļ�ȫ��������Server\RobotĿ¼������Ϊ����������Դ
4. GlobeVar.cs��¼��һЩ����
  (1)m_ProgramVersion   �������汾�Բ��ϣ����ܵ�½
  (2)m_IsEnableLogConsole ����̨��־   m_IsEnableLogFile д����־�ļ�
5. Program.cs�ļ����� framecount �ֶΣ�������ص��ԵĻ�����ý� (framecount >= 1000) ��ע�ʹ򿪣�
6. ȷ����Ҫ���Եķ�����id���� Robot\robotclient\serverlist.txt ���д��ڶ�Ӧ����
-------------------------------------------------------



������������exe���ˣ�������־��
����ܵ�ԭ���ǣ�������д��serverID����serverlist.txt���Ҳ���

-------------------------------------------------
��δ��?
Unity�༭��->�˵�->Robot->���
���ɵ�exe������Bin/robot/SecretRobot.exe

-------------------------------------------------
������ɲ����ļ�?
1.�༭��ǰĿ¼�µĲ��������ļ� deploylist.txt����ʹ��excel�༭��
2.ִ��convert_deploylist.cmd
3.Unity�༭��->�˵�->Robot->���ɲ�������
4.���ɵ�cmd��deployĿ¼��

-------------------------------------------------
�������з�ʽ����������
������
    start SecretRobot.exe -robotIdx 111 -serverId 1001 -aiType 0 -robotNum 2000 -isLog false -initId 1 -arg0 1000 -arg1 0 -arg2 0

���������
-robotIdx 111

������id, regionģʽ������regionid
-serverId 1001 

�Ƿ����ӵ�¼������ ��ȡserverlist.txt���� ���룺StateConnectLoginServer.cs��
-useLoginServer true

�Ƿ����ģʽ��ȡregion.txt���� ���룺StateConnectLoginServer.cs��
-isRegionLogin true

AI���ͣ����±�
-aiType 0

����������
-robotNum 2000

�Ƿ����־
-isLog false

�����˳�ʼid
-initId 1

����0
-arg0 1000 

����1
-arg1 0

����2
-arg2 0

--------------------------------
��ѡ��AI����
0 ������Ϸ����������
1 �½ڣ�����/���ߣ�
2 ���ŵ���
3 ����
4 ����
5 ʱ�����
6 ����
7 �鿨
8 ��Ʒ
9 ����
10 ����
11 �ʼ�
12 ����
13 ʱװ
14 ����
15 ��������
16 ���������Ϣ
17 �����Ϣ��
18 ����ֽ�

------------------------------------
Centos���л����˻���
�ο�	https://www.mono-project.com/download/stable/#download-lin-centos
��װmono		yum install mono-devel




