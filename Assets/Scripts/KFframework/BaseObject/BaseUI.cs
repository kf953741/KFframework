using UnityEngine;
using System.Collections;

public abstract class BaseUI : MonoBehaviour
{

    private GameObject cacheGameObject;
    public GameObject CacheGameObject
    {
        get
        {
            if (null == cacheGameObject)
            {
                cacheGameObject = this.gameObject;

            }
            return cacheGameObject;
        }
    }

    private Transform cacheTransform;
    public Transform CacheTransform
    {
        get
        {
            if (null == cacheTransform)
            {
                cacheTransform = this.transform;
            }
            return cacheTransform;
        }
    }

    protected EnumObjectState _state = EnumObjectState.None;

    public event StateChangeEvent StateChanged;

    public EnumObjectState State
    {
        protected get
        {
            return this._state;
        }
        set
        {
            EnumObjectState oldState = this._state;
            this._state = value;
            if (null != StateChanged)
            {
                StateChanged(this, this._state, oldState);
            }

        }
    }

    public abstract EnumUIType GetUIType();
    // Use this for initialization

    void Awake()
    {
        OnAwake();
    }
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected virtual void OnAwake() { }
    protected virtual void OnStart() { }
}
