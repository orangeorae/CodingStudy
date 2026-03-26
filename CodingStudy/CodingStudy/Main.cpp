#include <iostream>
using namespace std;

int main()
{
    int array[7][7] = { { 0,1,0,2,0,0,0 },
                        { 0,0,0,0,0,0,0 },
                        { 0,2,0,1,0,0,0 },
                        { 0,0,0,0,0,2,0 },
                        { 0,2,0,0,0,0,0 },
                        { 0,0,0,1,0,2,0 },
                        { 0,0,0,0,0,0,0 } };

    cout << "보물 찾기 게임 시작" << endl;

    int itemCount = 3;

    while (1) {

        int x = 0;  int y = 0;

        cout << "X, Y 좌표를 입력하세요: ";
        cin >> x >> y;

        if (x > 6 || x < 0 || y > 6 || y < 0) {
            cout << " 0부터 6사이에 수를 입력해주세요" << endl;
            continue;
        }
        else if (array[x][y] == 0) {
            cout << "빈칸입니다 ! 다시 입력해주세요" << endl;
            continue;
        }

        else if (array[x][y] == 2) {
            cout << "몬스터 발견! 죽었습니다." << endl;
            break;
        }

        if (array[x][y] == 1) {
            itemCount--;
            cout << "아이템  당첨! " << endl;

            cout << "남은 아이템의 수는 " << itemCount << "개 입니다." << endl;;

            if (itemCount == 0) {
                cout << "아이템을 전부 찾았습니다 성공 !";
                break;
            }
        }
    }
}