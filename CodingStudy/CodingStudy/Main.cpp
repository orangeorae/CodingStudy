#include <iostream>
using namespace std;

string AIRandom;

void Scissors() {
    if (AIRandom == "보") {
        cout << "가위바위보 대결에서 이겼습니다." << endl;
    }
    else if (AIRandom == "가위") {
        cout << "가위바위보 대결에서 비겼습니다." << endl;
    }
    else if (AIRandom == "바위") {
        cout << "가위바위보 대결에서 졌습니다." << endl;
    }
}

void Rock() {
    if (AIRandom == "가위") {
        cout << "가위바위보 대결에서 이겼습니다." << endl;
    }
    else if (AIRandom == "바위") {
        cout << "가위바위보 대결에서 비겼습니다." << endl;
    }
    else if (AIRandom == "보") {
        cout << "가위바위보 대결에서 졌습니다." << endl;
    }
}

void Paper() {
    if (AIRandom == "바위") {
        cout << "가위바위보 대결에서 이겼습니다." << endl;
    }
    else if (AIRandom == "보") {
        cout << "가위바위보 대결에서 비겼습니다." << endl;
    }
    else if (AIRandom == "가위") {
        cout << "가위바위보 대결에서 졌습니다." << endl;
    }
}
int main() {

    srand(time(NULL));
    int random = rand() % 3 + 1;
    string myValue;

    cout << "*****가위, 바위, 보 중에 입력해주세요.*****" << endl;
    cout << "입력: ";
    cin >> myValue;

    switch (random) {
    case 1:
        AIRandom = "가위";
        break;
    case 2:
        AIRandom = "바위";
        break;
    case 3:
        AIRandom = "보";
        break;
    }

    if (myValue == "가위") {
        cout << "상대는 " << AIRandom << "를 냈습니다." << endl;
        Scissors();
    }
    else if (myValue == "바위") {
        cout << "상대는 " << AIRandom << "를 냈습니다." << endl;
        Rock();
    }
    else if (myValue == "보") {
        cout << "상대는 " << AIRandom << "를 냈습니다." << endl;
        Paper();
    }
    else {
        cout << "가위, 바위, 보 중에 적어주세요." << endl;
    }
}