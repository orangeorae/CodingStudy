#include<iostream>
#include<string>
using namespace std;

void DropItem(); // 전방선언 
string job;

int map[7][7] = { 0 };
int px = 0; //플레이어의 x 값 
int py = 0; // 플레이어의 y값

string inventory[10];
int itemCount = 0;

void SpawnMonster() {
    while (true) {
        int mx = rand() % 7;
        int my = rand() % 7;

        if (map[my][mx] == 0) {
            map[my][mx] = 1;
            break;
        }
    }
}
//void SpawnMonster(int count) { // 괴물 여러명 하고 싶을때 다시 쓸 함수 
//    int placed = 0; // 괴물 수 조절을 위함
//
//    while (placed < count) {
//
//        int mx = rand() % 7; // 0~ 6의 숫자
//        int my = rand() % 7;
//
//        if (map[my][mx] == 0) { //괴물 x y 좌표에 값이 0이면 1로 만들고 괴물의 수를 늘린다
//            map[my][mx] = 1;
//            placed++;
//        }
//    }
//}

void PrintMap() {
    cout << "\n=====GAME MAP =====\n";
    for (int y = 0; y < 7; y++) {
        for (int x = 0; x < 7; x++) {
            if (x == px && y == py) { // x 값이 0이고 y값도 0일 때 P 즉 플레이어 위치는 (0,0)
                cout << "P ";
            }
            else if (map[y][x] == 1) {
                cout << "M ";
            }
            else
                cout << ". ";
        }
        cout << endl;
    }
}

void DropItem() {

    int  r = rand() % 2;

    if (r == 0) {
        inventory[itemCount++] = "괴물의 심장";
        cout << "전리품 획득! 괴물의 심장" << endl;
    }
    else {
        inventory[itemCount++] = "괴물의 쓸모 없는 아이템";
        cout << "전리품 획득! 괴물의 쓸모 없는 아이템 " << endl;
    }

}

class Character {
public:
    int hp;
    int atk;
    string name;

    void Attack(Character& target) {
        cout << "[" << name << "] → [" << target.name << "] : " << atk << " 데미지!" << endl;
        target.Damage(atk);
    }

    void Damage(int dmg) {
        hp = hp - dmg;
        if (hp < 0) {
            hp = 0;
        }
        cout << "[" << name << "] 피해: " << dmg << " | 남은 HP: " << hp << endl;
    }
};

class Wizard : public Character { // 기본 접근 지정자는 private으로 되어있다
public:
    Wizard() {
        hp = 80;
        atk = 70;
    }
};

class Archer : public Character {
public:
    Archer() {
        hp = 100;;
        atk = 50;
    }
};

class Warrior : public Character {
public:
    Warrior() {
        hp = 130;
        atk = 30;
    }
};


class Player : public Character {
public:
    string job = "Null";

    Player() {
        name = "플레이어";
    }

    void SetJob(Character* c, string jobName) {
        job = jobName;
        hp = c->hp;
        atk = c->atk;

    }

    void PrintStatus() {
        cout << " \n ===== 플레이어 정보 =====\n";
        cout << "직업: " << job << endl;
        cout << "체력: " << hp << endl;
        cout << "공격력: " << atk << endl;
        cout << "=========================\n";
    }
};

class Monster : public Character {
public:

    Monster(string n, int h, int a) {
        name = n;
        hp = h;
        atk = a;
    }
    bool IsDead() {
        return hp <= 0;
    }
};

bool fight(Player& player, Monster& monster) {
    cout << "\n전투시작 ! [" << monster.name << "] 등장!\n";

    while (true) {
        //플레이어
        cout << "\n 당신의 공격\n";
        player.Attack(monster);

        if (monster.IsDead()) {
            cout << monster.name << "처치!\n";
            return true;
        }

        //괴물
        cout << monster.name << "의 반격!\n";
        monster.Attack(player);


        if (player.hp <= 0) {
            cout << "당신은 사망했습니다... " << endl;
            return false;
        }
    }
}

void MovePlayer(Player& player) {
    char input;
    cout << "\nwasd로 이동하세요(소문자만 적어주세요): ";
    cin >> input;

    int nx = px;
    int ny = py;
    /*y→    x →
        0   1   2   3   4   5   6
        --------------------------------
        0 | (0, 0)(1, 0)(2, 0)(3, 0)(4, 0)(5, 0)(6, 0)
        1 | (0, 1)(1, 1)(2, 1)(3, 1)(4, 1)(5, 1)(6, 1)
        2 | (0, 2)(1, 2)(2, 2)(3, 2)(4, 2)(5, 2)(6, 2)
        3 | (0, 3)(1, 3)(2, 3)(3, 3)(4, 3)(5, 3)(6, 3)
        4 | (0, 4)(1, 4)(2, 4)(3, 4)(4, 4)(5, 4)(6, 4)
        5 | (0, 5)(1, 5)(2, 5)(3, 5)(4, 5)(5, 5)(6, 5)
        6 | (0, 6)(1, 6)(2, 6)(3, 6)(4, 6)(5, 6)(6, 6)*/

    if (input == 'w') ny--;
    else if (input == 's') ny++;
    else if (input == 'a') nx--;
    else if (input == 'd') nx++;

    if (nx < 0 || nx >= 7 || ny < 0 || ny >= 7) {
        cout << "벽입니다 이동이 불가합니다." << endl;
        return;
    }

    px = nx;
    py = ny;

    if (map[py][px] == 1) {
        cout << "\n 괴물을 만났습니다. 전투를 하시겠습니까? (y/n): ";
        char answer;
        cin >> answer;

        Monster mon("괴물", 120, 20);

        if (answer == 'y') {
            bool win = fight(player, mon);

            if (win) {
                map[py][px] = 0;
                DropItem();

                cout << "\n====================\n";
                cout << "   괴물을 처치했다 ! 당신의 승리입니다!" << endl;
                cout << "\n====================\n";

                exit(0);
            }
        }
        else {
            cout << "도망치기 성공!" << endl;
        }
    }

}
void Enter() { // 엔터 기능을 위해 
    cout << "                   (Enter)";
    /*cin.ignore(numeric_limits < streamsize>::max(), '\n');*/
    // 입력을 받았을 때 엔터가 들어가면 
    // get함수가 무시될 수 있으니까 입력된 값을 버려주는것
    cin.get();
}
void FirstStory() {
    cout << "나는 하루하루 재미없는 삶에서 벗어나기 위해 모험을 떠나기로 했다.";
    Enter();
    cout << "그래서 직업을 부여해준다는 옆집에 사는 직업 트레이너를 만나기로 했다.";
    Enter();
    cout << "---------- 뚜벅... 뚜벅... ----------";
    Enter();
    cout << "----------트레이너 집 도착 ----------";
    Enter();
    cout << "안녕 나는 직업 트레이너야 너는 이제부터 모험을 시작하게 될 거야";
    Enter();
    cout << "너에게 직업을 하나 부여해줄게, 너는 너가 선택한 직업으로 모험을 하며 괴물을 죽이게 될거야";
    Enter();
    cout << "너가 괴물을 처치하게 전리품이 나와 그 중에 괴물의 심장은 아주 비싸게 팔린단다.";
    Enter();
    cout << "직업은 마법사, 궁수 전사가 있어 어떤 직업을 갖고 싶니?";
}

int main()
{
    Player player; // 플레이어 객체 생성
    FirstStory();
    cin >> job;
    //초기값 ,  없는 직업을 입력했을 때 아무 객체도 가리키지 않기 위해
    Character* selected = nullptr;
    if (job == "마법사") {//마법사를 선택, 이 정보를 selected 에 담는다
        selected = new Wizard();
    }

    else if (job == "궁수") {
        selected = new Archer();
    }

    else if (job == "전사") {
        selected = new Warrior();
    }

    else {
        cout << "존재하지 않는 직업입니다.";
        return 0;
    }
    player.SetJob(selected, job);
    player.PrintStatus();

    srand((unsigned)time(0));
    SpawnMonster();

    while (player.hp > 0) {
        PrintMap();
        MovePlayer(player);

    }
}