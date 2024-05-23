using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterTypeController : MonoBehaviour
{
    [SerializeField] private RectTransform textobj;
    [SerializeField] private TMP_Text textResult;
    [SerializeField] private GameObject undHolder;
    [Header("Character Parts")]
    [SerializeField] private GameObject head;
    [SerializeField] private GameObject torso;
    [SerializeField] private GameObject leftarm;
    [SerializeField] private GameObject rightarm;
    [SerializeField] private GameObject leftleg;
    [SerializeField] private GameObject rightleg;

    [SerializeField] private Material normal;
    [SerializeField] private Material normalclothed;

    [Header("Reikgon Properties")]
    [SerializeField] private GameObject eyes;
    [SerializeField] private Material black;
    [SerializeField] private Material blackclothed;

    private List<Action> methods = new();
    private void Start()
    {
        methods.Add(() => Human());
        methods.Add(() => Reikgon());
    }
    public void ChangeCharacter(int num)
    {
        methods[num].Invoke();
    }
    public void Human()
    {
        textobj.sizeDelta = new Vector2(0, 4060);
        textResult.text = "Before the Collapse, Eden-227 used to be a man-made paradise, full of vibrant life and bustling resort cities. However with the fall of the Neo-Thermal generators, those who haven’t gone off-world had been stranded on a frozen, decaying shell of a once hospitable planet. Now any of those who haven’t died to the Systemic Infection, the freezing cold environment, or to the myriad other different circumstances one can die on this planet have joined several different factions out of necessity. Those who wished to remain lone wanderers, or those that joined too late have died or been killed one way or another, their bodies looted for what little they had and the memory of them forever lost.\r\n\r\nOne such faction and by far the largest are the Scavengers. It is a very loose, almost tribal organization and it is led by Yosef Agafonov, an ex-member of the Agency and an extremely tough man who casually wields an M60 light machine gun. \r\nWhile they are the worst equipped and least skilled faction on Eden-227, they are still very much capable of killing anyone who gets just a little bit too careless. Not many people can stand up to being repeatedly shot while their body is pierced, their limbs slashed off and their bones smashed to bits.\r\nDo not let the fact they are all in one group fool you however, they are mostly made up of criminals that have no qualms with stealing from and even killing one another if the opportunity arises and it is convenient to do so. Survival is their number one goal, and they will achieve it in any way possible.\r\n\r\nAnother group are the Sledge Queen’s Raiders. Unlike the Scavengers they are few in number but are very well equipped and highly skilled. Even the weakest raider is capable of taking on all but Yosef’s guards and Yosef himself. The Raiders are led by a woman named Aila, who has taken on the title of “Sledge Queen”. She is extremely aggressive in her fighting style, literally blasting herself at her enemy using a looted Agency augment and crushing all who oppose her with her trusty sledgehammer.\r\nThe Raiders mostly reside in a ruined castle, which they have taken as their home base. There they store all of their collected loot, which has garnered the attention of many greedy eyes. However, any who do try to take things from the Raiders quickly learn how being shot repeatedly with a 7.62mm bullet feels like.\r\n\r\nThe most secretive major group on the wasteland of Eden-227 is the Cult of Reikgon. Not much is known about them, as they mostly keep to themselves. Anyone that is curious enough to investigate will soon realize that the Cultists do not enjoy being disturbed.\r\nMembers of the cult generally specialize in melee combat, utilizing ceremonial knives dipped in poison to make their opponents easy prey. While some do use guns like the TEC-9, their accuracy is much to be desired. \r\nThe Cult itself seems to be led by the High Priest, who wields a shadowy scythe alongside a firearm. He is a highly fearsome foe in melee combat, knowing advanced CQC techniques and dealing heavy blows to any who dare face him. And even though he is a bit of a pushover at range, he has the speed to quickly close the gap and the ability to shadowmeld, temporarily becoming immune to gun-based attacks. \r\nAs the name implies, the Cult of Reikgon worships creatures known as Reikgon Shadows, former humans which have been afflicted by the Reikgon bioweapon. It is theorized that all cultists have some form of said bioweapon contained within their bodies, as they act as though they were part of one hivemind. Good luck asking them to confirm that though, any who are curious enough realize too late that they do not enjoy being disturbed.\r\n\r\nThe final major faction on Eden is the Agency. They vastly differ from the other groups by being on Eden-227 out of choice, rather than due to not being able to leave. Agents of the Agency are biologically engineers superhumans, who are able to take blows which would kill normal people and walk away from them as though nothing had happened. They are also oftentimes augmented with various cybernetics and specialized upgrades, or “perks” as they call them. Even though they are the least numerous group, each group of Agents consisting of at most 5 man squads, every single Agent is fully capable of killing hundreds of scavengers on their own.\r\nThe Agency’s overall goal on Eden is currently unknown. As of right now, their missions consist of mostly reconnaissance, search & rescue and object retrieval. Despite the Agents being powerful and extremely dangerous, they are nonetheless targeted by most scavengers for the high value equipment they were given by the Agency.\r\n\r\nEven though all of these factions are unlike one another, there is one thing that unites all humans. No matter who they are, no matter how powerful they may be, they will all eventually fall to the decaying winter of a lifeless husk of paradise.";
        undHolder.GetComponent<MeshRenderer>().material = normalclothed;
        eyes.SetActive(false);
        head.GetComponent<SkinnedMeshRenderer>().material = normal;
        leftarm.GetComponent<SkinnedMeshRenderer>().material = normal;
        rightarm.GetComponent<SkinnedMeshRenderer>().material = normal;
        if (torso.transform.childCount > 0)
            torso.GetComponent<SkinnedMeshRenderer>().material = normal;
        else
            torso.GetComponent<SkinnedMeshRenderer>().material = normalclothed;
        if (leftleg.transform.childCount > 0 && rightleg.transform.childCount > 0)
        {
            leftleg.GetComponent<SkinnedMeshRenderer>().material = normal;
            rightleg.GetComponent<SkinnedMeshRenderer>().material = normal;
        } else
        {
            leftleg.GetComponent<SkinnedMeshRenderer>().material = normalclothed;
            rightleg.GetComponent<SkinnedMeshRenderer>().material = normalclothed;
        }
    }
    public void Reikgon()
    {
        textobj.sizeDelta = new Vector2(0, 1400);
        textResult.text = "A result of a catastrophic side effect to a bioweapon, which was originally intended to just fight and eventually eliminate the Systemic Infection. While it did kill bacteria which caused the plague of Eden, it also killed the host due to its intensity. As if that wasn’t enough, after killing the host it then mutated the host’s body and took control of it, seeking to kill anyone who was suffering from the Systemic Infection.\r\n\r\nAfter undergoing the mutation, a corpse is transformed into a “Reikgon Shadow”. These Shadows are characterized by their bright, glowing red eyes and black fur, and can take on many different forms, some being completely invisible while others have gained vastly increased strength, endurance and reflexes. If the host had an exceptionally strong consciousness, the resulting Shadow would become withdrawn, attempting to avoid anyone they saw, as the flicker of consciousness that remained knew that as soon as anyone infected stepped too close, they would completely lose control and charge at any poor soul who just happened to be nearby. Shadows like that had been nicknamed “Sicklers” by the residents of Eden for these reasons. And one certainly does not want to alert and anger them, as they are exceptionally strong and nearly unstoppable, their claws being able to rip normal men in half without much struggle.\r\n\r\nUnder normal circumstances, the mind of the host is wiped clean upon becoming a Reikgon Shadow, however for whatever reason YOU specifically appear to have kept not just your consciousness and personality, but also nearly full control of your body. Certainly a strange case indeed.\r\n\r\nYou have been gifted with a second chance at life by fate, life, this accursed planet or whatever god or gods you believe in. Make it count.\r\n";
        undHolder.GetComponent<MeshRenderer>().material = blackclothed;
        eyes.SetActive(true);
        head.GetComponent<SkinnedMeshRenderer>().material = black;
        leftarm.GetComponent<SkinnedMeshRenderer>().material = black;
        rightarm.GetComponent<SkinnedMeshRenderer>().material = black;
        if (torso.transform.childCount > 0)
            torso.GetComponent<SkinnedMeshRenderer>().material = black;
        else
            torso.GetComponent<SkinnedMeshRenderer>().material = blackclothed;
        if (leftleg.transform.childCount > 0 && rightleg.transform.childCount > 0)
        {
            leftleg.GetComponent<SkinnedMeshRenderer>().material = black;
            rightleg.GetComponent<SkinnedMeshRenderer>().material = black;
        }
        else
        {
            leftleg.GetComponent<SkinnedMeshRenderer>().material = blackclothed;
            rightleg.GetComponent<SkinnedMeshRenderer>().material = blackclothed;
        }
    }
}
