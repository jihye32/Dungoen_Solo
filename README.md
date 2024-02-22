### 미완성
----
선택한 아이템 정보 가져오는 법을 아직 잘 모르겠습니다.
인벤토리 슬롯을 만들 때 아이템 정보를 받을 수 있도록 설정해야 됐을 것이라고 생각을 하는데 잘 모르겠습니다.

----

# ReadMe 수정 (2024.2.27 20:40)

### 1차 제출 브렌치 : NOFINISH

### 2차 제출 브렌치 : Make_New

### 개발 심화 브렌치 : MakeForFinish
----
## 2차 제출 수정사항

1. 캐릭터 움직이지 못함. -> 1차 제출과 같게 설정했다고 생각되지만 추가로 안넣어진 것이 있을 것으로 추정. 고치지는 않음
2. 캐릭터 레벨 바 수정 -> 현재 가지고 있는 EXP와 레벨 업에 필요한 EXP 설정 및 비율 적용.
3. 캐릭터 정보 UI 수정 -> 생성되는 위치와 내용 변경. 정보에 맞는 아이콘은 원하는게 없어서 추가 못함.
4. 인벤토리 UI 수정 -> 인벤토리 생성 배열 수정(2차원 -> 1차원, Grid Layout Group 사용). **onClick.AddListener을 이용해서 슬롯에 있는 아이템 정보 가져옴.**
5. class Item -> 아이템 추가 가능. 추가된 아이템 장착/해제 가능(장착 시 슬롯UI 변경). 아이템 장착 시 캐릭터 스탯 수정.
6. 상점 NPC 삭제 -> 시간 부족으로 다시 생성 불가..


----
## 추가(2024.2.20)

[1. 게임화면](#게임화면)

[2. 버튼](#버튼)

[3. NPC 생성](#NPC-생성)

[4. Json](#Json)


----

### 게임화면
#### 1. 시작화면
- 게임시작 버튼을 클릭하면 SelectScene으로 이동.

#### 2. 선택화면
- 플레이할 캐릭터를 선택하고 이름을 입력하여 확정을 누르면 MainScene으로 이동.
- 선택한 캐릭터는 인덱스로 저장.
- 추가되야할 것 : 캐릭터 갯수, 캐릭터 설명

#### 3. 메인화면
- A, D를 이용하여 좌우로 이동 가능
- NPC 머리 위에 [W] 판넬이 뜬 상태에서 W를 누르면 NPC와 대화 가능.
- 추가되야할 것 : NPC와 대화하는 중에는 PlayerInput 컴포넌트 enable = false (ReadMe 적다가 생각남)
#### 4. 던전
- 턴제로 공격
- 캐릭터 레벨에 따라 생성되는 적의 갯수 변경
- 캐릭터 이동 불가
- 추가되야할 것 : 캐릭터 공격, 캐릭터 피격, 적 공격, 턴제로 공격할 수 있도록 설정.

----

### 버튼

- 모든 씬에서 사용되는 버튼은 AddListener을 이용해서 설정해줌.

----

### NPC 생성

1. 상점 NPC

![image](https://github.com/jihye32/Dungoen_Solo/assets/154485025/7351453f-5009-45a6-acec-095898738eb2)
![image](https://github.com/jihye32/Dungoen_Solo/assets/154485025/2c5eef4d-908d-484c-aa8d-9d87a3269018)

- 지정해둔 거리보다 멀면 상호작용UI.SetActive(false)

![image](https://github.com/jihye32/Dungoen_Solo/assets/154485025/1a14bf36-15ad-469f-b49e-39d5482351a5)

- 상호작용UI.SetActive(true) 에서 W를 누르면 상점 NPC와 대화를 나눌 수 있음.
- 현재 상점생성을 하지 않았으므로 안내 말풍선은 2초 뒤에 사라짐

2. 던전 입장 NPC

![image](https://github.com/jihye32/Dungoen_Solo/assets/154485025/00f41db3-487f-4c9a-af6a-83329f432493)

- 상점 NPC와 동일

  
![image](https://github.com/jihye32/Dungoen_Solo/assets/154485025/1434acef-19dc-4b74-b4f7-868c5341e49d)

- 던전 입장 버튼 클릭 시 던전Scene으로 이동.
- 나가기 버튼 클릭 시 말풍선 사라짐.
- 현재 테스트용으로 오른쪽으로 죽 직진하면 던전Scene으로 이동됨.

----

### Json

- 외부에 데이터를 저장해서 불러오는 방식
- 새로운 파일을 만들어줌.

```
public class PlayerData
```
- 캐릭터의 정보를 가지고 있음.
- SelectScene에서 name과 characterIndex를 받아서 저장됨.
- MainScene에서 나머지 부분에 대한 값들을 받아줌.
- MainScene에서 저장은 던전으로 입장할 때.

```
private PlayerData playerData = new PlayerData();
string path = $"{Application.persistentDataPath}/save";

public void SaveData(PlayerData Data)
{
    playerData = Data;
    string data = JsonUtility.ToJson(playerData);

    File.WriteAllText(path, data);
}
```

- 캐릭터 정보를 저장하는 함수
- path = 유니티에서 만들어주는 경로/생성하는 파일 명
- playerData를 Json으로 변환해줌. 이때 string으로 반환됨.
- string으로 반환된 Json을 File로 생성해서 지정해준 경로에 파일을 생성해줌.
- 무분별하게 사용 시 과부화 걸릴 수 있음.

```
public void LoadData()
{
    string data = File.ReadAllText(path);
    playerData = JsonUtility.FromJson<PlayerData>(data);
}
```

- 저장되어있는 Json파일을 불러옴.
- Scene이 연결되어 있으면 한번만 불러오면 충분.
- 던전Scene에는 테스트로 인하여 한번 더 불러와 줌.

```
public PlayerData GetPlayerData()
{
    return playerData;
}
```
- playerData를 가져옴.
- LoadData와 달리 계속 불러와도 됨.
- SaveData를 안하고 불러오면 저장안되어있는 파일이 불러와지므로 주의 필요.
  














