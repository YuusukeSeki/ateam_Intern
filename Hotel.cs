using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ateam
{
    public class Hotel : BaseBattleAISystem
    {
        public float _preHp0;   // 前フレームのHp（メイン）
        public float _preHp1;   // 前フレームのHp（サブ１）
        public float _preHp2;   // 前フレームのHp（サブ２）

        public int _actorId0;   // ID（メイン）
        public int _actorId1;   // ID（サブ１）
        public int _actorId2;   // ID（サブ２）



        //---------------------------------------------------
        // InitializeAI
        //---------------------------------------------------
        override public void InitializeAI()
        {
            // 前フレームのHP初期化
            _preHp0 = GetCharacterData(0).Hp;
            _preHp1 = GetCharacterData(1).Hp;
            _preHp2 = GetCharacterData(2).Hp;

            // キャラクターの取得
            //TEAM_TYPE.PLAYER.



            // 経路探索

            // 移動ルーチン

            // ダメージ判定

            // アイテム使用判定

            // 攻撃ルーチン

            // パラメータ管理



            //List<CharacterModel.Data> list = GetTeamCharacterDataList(TEAM_TYPE.PLAYER);
            //CharacterModel.Data Data = list.Find(obj => obj.ActorId == 0);

            //if(Data != null)
            //    _Id0 = 0;
            //else
            //    _Id0 = 3;



            //ActorData? actorData = ApplicationManager.Instance.ActorManager.GetActor(Data.ActorId);

            //Character character = actorData.Value.Actor.GetComponent<Character>();

            //if (character == null)
            //{
            //    return false;
            //}

            //return character.ActionManager.StartAction(type);


        }

        //---------------------------------------------------
        // UpdateAI
        //---------------------------------------------------
        override public void UpdateAI()
        {

            // 経路探索

            // 移動ルーチン

            //----- ダメージ判定 -----
            if (IsDamage(0))
            {
                Move(0, Common.MOVE_TYPE.UP);
            }


            // アイテム使用判定
            




            // 攻撃ルーチン

            // パラメータ管理


            // 前フレームのHpバッファを更新
            _preHp0 = GetCharacterData(0).Hp;
            _preHp1 = GetCharacterData(1).Hp;
            _preHp2 = GetCharacterData(2).Hp;

        }

        //---------------------------------------------------
        // ItemSpawnCallback
        //---------------------------------------------------
        override public void ItemSpawnCallback(ItemSpawnData itemData)
        {



        }

        // ダメージ差分があるかどうか
        public bool IsDamage(int actorId)
        {
            switch (actorId)
            {
                // ダメージ変更差分検出（メイン）
                case 0:
                    if (_preHp0 != GetCharacterData(0).Hp)
                        return true;
                    else
                        return false;

                // ダメージ変更差分検出（サブ１）
                case 1:
                    if (_preHp1 != GetCharacterData(1).Hp)
                        return true;
                    else
                        return false;

                // ダメージ変更差分検出（サブ２）
                case 2:
                    if (_preHp2 != GetCharacterData(2).Hp)
                        return true;
                    else
                        return false;

            }

            return false;
        }
    }
}

