### 미완성
----
선택한 아이템 정보 가져오는 법을 아직 잘 모르겠습니다.
인벤토리 슬롯을 만들 때 아이템 정보를 받을 수 있도록 설정해야 됐을 것이라고 생각을 하는데 잘 모르겠습니다.

----

## ReadMe 수정 (2024.2.27 20:40)

#### 1차 제출 브렌치 : NOFINISH

#### 2차 제출 브렌치 : Make_New
----
### 2차 제출 수정사항

1. 캐릭터 움직이지 못함. -> 1차 제출과 같게 설정했다고 생각되지만 추가로 안넣어진 것이 있을 것으로 추정. 고치지는 않음
2. 캐릭터 레벨 바 수정 -> 현재 가지고 있는 EXP와 레벨 업에 필요한 EXP 설정 및 비율 적용.
3. 캐릭터 정보 UI 수정 -> 생성되는 위치와 내용 변경. 정보에 맞는 아이콘은 원하는게 없어서 추가 못함.
4. 인벤토리 UI 수정 -> 인벤토리 생성 배열 수정(2차원 -> 1차원, Grid Layout Group 사용). **onClick.AddListener을 이용해서 슬롯에 있는 아이템 정보 가져옴.**
5. class Item -> 아이템 추가 가능. 추가된 아이템 장착/해제 가능(장착 시 슬롯UI 변경). 아이템 장착 시 캐릭터 스탯 수정.
6. 상점 NPC 삭제 -> 시간 부족으로 다시 생성 불가..

