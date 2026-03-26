#include <iostream>
using namespace std;

int main()
{
    int array[7][7] = { 0 };
    int itemCount = 0;
    int monsterCount = 0;
    srand(time(0));

    for (int i = 0; i < 7; i++) {

        for (int j = 0; j < 7; j++) {

            int item = rand() % 3; //0~2

            if (item == 1) {

                if (itemCount < 3) { // 아이템 최대 수 조절 
                    array[i][j] = 1;
                    itemCount++;
                }
                else {
                    array[i][j] = 0;
                }
            }
            else if (item == 2) {
                if (monsterCount < 5) { // 몬스터 최대 수 조절
                    array[i][j] = 2;
                    monsterCount++;
                }
                else {
                    array[i][j] = 0;
                }
            }
        }
    }
    cout << "보물 찾기 게임 시작" << endl;
    while (1) {
        int x = 0, y = 0;
        cout << "X, Y 좌표를 입력하세요: ";
        cin >> x >> y;

        if (x < 0 || x > 6 || y < 0 || y >6) {
            cout << "0~ 6 까지의 숫자를 적어주세요" << endl;
            continue;
        }

        if (array[x][y] == 2) {
            cout << "몬스터 발견 게임오버" << endl;
            break;
        }

        if (array[x][y] == 1) {
            cout << "아이템 발견 성공! ";
            break;
        }
        else if (array[x][y] == 0) {
            cout << "빈칸입니다. 다시 입력해주세요" << endl;
            continue;
        }
    }
}
