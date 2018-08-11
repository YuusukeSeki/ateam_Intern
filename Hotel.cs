using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ateam
{
    public class Hotel : BaseBattleAISystem
    {
        public float _preHp0;   // �O�t���[����Hp�i���C���j
        public float _preHp1;   // �O�t���[����Hp�i�T�u�P�j
        public float _preHp2;   // �O�t���[����Hp�i�T�u�Q�j

        public int _actorId0;   // ID�i���C���j
        public int _actorId1;   // ID�i�T�u�P�j
        public int _actorId2;   // ID�i�T�u�Q�j



        //---------------------------------------------------
        // InitializeAI
        //---------------------------------------------------
        override public void InitializeAI()
        {
            // �O�t���[����HP������
            _preHp0 = GetCharacterData(0).Hp;
            _preHp1 = GetCharacterData(1).Hp;
            _preHp2 = GetCharacterData(2).Hp;

            // �L�����N�^�[�̎擾
            //TEAM_TYPE.PLAYER.



            // �o�H�T��

            // �ړ����[�`��

            // �_���[�W����

            // �A�C�e���g�p����

            // �U�����[�`��

            // �p�����[�^�Ǘ�



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

            // �o�H�T��

            // �ړ����[�`��

            //----- �_���[�W���� -----
            if (IsDamage(0))
            {
                Move(0, Common.MOVE_TYPE.UP);
            }


            // �A�C�e���g�p����
            




            // �U�����[�`��

            // �p�����[�^�Ǘ�


            // �O�t���[����Hp�o�b�t�@���X�V
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

        // �_���[�W���������邩�ǂ���
        public bool IsDamage(int actorId)
        {
            switch (actorId)
            {
                // �_���[�W�ύX�������o�i���C���j
                case 0:
                    if (_preHp0 != GetCharacterData(0).Hp)
                        return true;
                    else
                        return false;

                // �_���[�W�ύX�������o�i�T�u�P�j
                case 1:
                    if (_preHp1 != GetCharacterData(1).Hp)
                        return true;
                    else
                        return false;

                // �_���[�W�ύX�������o�i�T�u�Q�j
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

