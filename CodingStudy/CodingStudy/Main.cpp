#include <iostream>
#include<string>
using namespace std;

class DragonMaster {
public:
    string m_dmName;
    int m_hp;

    DragonMaster(string name, int hp) {
        m_dmName = name;
        m_hp = hp;
        cout << m_dmName << "가 소환되었습니다." << endl;
    }

    void Bress() {
        cout << m_dmName << "의 드래곤이 브레스를 내뿜어서 데미지를 입혔다." << endl;
    }
    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_dmName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~DragonMaster() {
    }

};

class JaguarHunter {
public:
    string m_jhName;
    int m_hp;

    JaguarHunter(string name, int hp) {
        m_jhName = name;
        m_hp = hp;
        cout << m_jhName << "가 소환되었습니다." << endl;
    }

    void Bite() {
        cout << m_jhName << "의  재규어가 물어서 데미지를 입혔다." << endl;
    }
    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_jhName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~JaguarHunter() {
    }

};

class WildPigHunter {
public:
    string m_phName;
    int m_hp;
    WildPigHunter(string name, int hp) {
        m_phName = name;
        m_hp = hp;
        cout << m_phName << "가 소환되었습니다." << endl;
    }

    void HeadButt() {
        cout << m_phName << "의  멧돼지가  박치기를 해서 데미지를 입혔다." << endl;
    }
    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_phName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~WildPigHunter() {
    }
};

int main()
{
    string  call;
    DragonMaster Dragon("드래곤마스터", 100); // 소환
    JaguarHunter Jaguar("재규어헌터", 100); // 소환 
    WildPigHunter WildPig("멧돼지헌터", 100); // 소환 
    cout << "***3명의 헌터가 소환 되었습니다.*** " << endl;
    while (1) {
        cout << "***누구를 선택해 공격시키겠습니까? (드래곤마스터/ 재규어헌터/ 멧돼지헌터)***" << endl;
        cout << "입력: ";
        cin >> call;
        if (call == "드래곤마스터") {
            Dragon.Bress();
            Jaguar.TakeDamage(30);
            WildPig.TakeDamage(30);
        }
        else if (call == "재규어헌터") {
            Jaguar.Bite();
            Dragon.TakeDamage(30);
            WildPig.TakeDamage(30);
        }
        else if (call == "멧돼지헌터") {
            WildPig.HeadButt();
            Dragon.TakeDamage(30);
            Jaguar.TakeDamage(30);
        }
        if (Dragon.m_hp <= 0) {
            cout << Dragon.m_dmName << "가 죽었습니다." << endl;
        }
        if (Jaguar.m_hp <= 0) {
            cout << Jaguar.m_jhName << "가 죽었습니다." << endl;
        }
        if (WildPig.m_hp <= 0) {
            cout << WildPig.m_phName << "가 죽었습니다." << endl;
        }

        if ((Dragon.m_hp <= 0 && Jaguar.m_hp <= 0)) {
            cout << "-----승자는 멧돼지헌터-----" << endl;
            break;
        }
        else if (Dragon.m_hp <= 0 && WildPig.m_hp <= 0) {
            cout << "-----승자는  재규어헌터-----" << endl;
            break;
        }
        else if (Jaguar.m_hp <= 0 && WildPig.m_hp <= 0) {
            cout << "-----승자는  드래곤헌터-----" << endl;
            break;
        }
    }
}
