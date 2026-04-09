#include <iostream>
#include<string>
using namespace std;

class JaguarHunter;
class WildPigHunter;

class DragonMaster {
public:
    string m_dmName;
    int m_hp;

    DragonMaster(string name, int hp) {
        m_dmName = name;
        m_hp = hp;
        cout << m_dmName << "가 소환되었습니다." << endl;
    }


    void Bress(JaguarHunter* targetJaguar);
    void Bress(WildPigHunter* targetWildPig);
    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_dmName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~DragonMaster() {
        cout << m_dmName << "가 죽었습니다." << endl;
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

    void Bite(DragonMaster* targetDragon) {
        cout << m_jhName << "의  재규어가 " << targetDragon->m_dmName << "를 물어서 데미지를 입혔다." << endl;
        targetDragon->TakeDamage(30);
    }

    void Bite(WildPigHunter* targetWildPig);

    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_jhName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~JaguarHunter() {
        cout << m_jhName << "가 죽었습니다." << endl;
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

    void HeadButt(DragonMaster* targetDragon) {
        cout << m_phName << "의  멧돼지가 " << targetDragon->m_dmName << "에게 박치기를 해서 데미지를 입혔다." << endl;
        targetDragon->TakeDamage(30);
    }
    void HeadButt(JaguarHunter* targetJaguar) {
        cout << m_phName << "의  멧돼지가 " << targetJaguar->m_jhName << " 박치기를 해서 데미지를 입혔다." << endl;
        targetJaguar->TakeDamage(30);
    }
    void TakeDamage(int damage) {
        m_hp = m_hp - damage;
        cout << m_phName << "가 " << damage << "의 피해를 입었다." << endl;
    }
    ~WildPigHunter() {
        cout << m_phName << "가 죽었습니다." << endl;
    }
};

void DragonMaster::Bress(JaguarHunter* targetJaguar) {
    cout << m_dmName << "의  드래곤이 " << targetJaguar->m_jhName << "에게 브레스를 내뿜어 데미지를 입혔다." << endl;
    targetJaguar->TakeDamage(30);
}
void DragonMaster::Bress(WildPigHunter* targetWildPig) {
    cout << m_dmName << "의  드래곤이 " << targetWildPig->m_phName << "에게 브레스를 내뿜어 데미지를 입혔다." << endl;
    targetWildPig->TakeDamage(30);
}
void JaguarHunter::Bite(WildPigHunter* targetWildPig) {
    cout << m_jhName << "의  재규어가 " << targetWildPig->m_phName << "를 물어서 데미지를 입혔다." << endl;
    targetWildPig->TakeDamage(30);
}

int main()
{
    string  call;
    DragonMaster* DragonM = new DragonMaster("드래곤마스터", 100);
    JaguarHunter* JaguarH = new JaguarHunter("재규어헌터", 100);
    WildPigHunter* WildPigH = new WildPigHunter("멧돼지헌터", 100);
    cout << endl;
    cout << "***3명의 헌터가 소환 되었습니다.*** " << endl;
    while (1) {
        cout << "***누구를 선택해 공격시키겠습니까? (드래곤마스터/ 재규어헌터/ 멧돼지헌터)***" << endl;
        cout << "입력: ";
        cin >> call;
        if (call == "드래곤마스터") {
            cout << endl;
            DragonM->Bress(JaguarH);
            DragonM->Bress(WildPigH);
        }
        else if (call == "재규어헌터") {
            cout << endl;
            JaguarH->Bite(DragonM);
            JaguarH->Bite(WildPigH);
        }
        else if (call == "멧돼지헌터") {
            cout << endl;
            WildPigH->HeadButt(DragonM);
            WildPigH->HeadButt(JaguarH);
        }
        else {
            cout << "이름을 잘못 입력 하셨습니다. 다시 적어주세요" << endl;
        }

        if ((DragonM->m_hp <= 0 && JaguarH->m_hp <= 0)) {
            cout << endl;
            delete DragonM;
            delete JaguarH;
            cout << endl;
            cout << "-----승자는 멧돼지헌터-----" << endl;
            DragonM = nullptr;
            JaguarH = nullptr;
            WildPigH = nullptr;
            break;
        }
        else if (DragonM->m_hp <= 0 && WildPigH->m_hp <= 0) {
            cout << endl;
            delete DragonM;
            delete WildPigH;
            cout << endl;
            cout << "-----승자는  재규어헌터-----" << endl;
            DragonM = nullptr;
            JaguarH = nullptr;
            WildPigH = nullptr;
            break;
        }
        else if (JaguarH->m_hp <= 0 && WildPigH->m_hp <= 0) {
            cout << endl;
            delete JaguarH;
            delete WildPigH;
            cout << endl;
            cout << "-----승자는  드래곤헌터-----" << endl;
            DragonM = nullptr;
            JaguarH = nullptr;
            WildPigH = nullptr;
            break;
        }
    }
}