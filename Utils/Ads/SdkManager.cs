using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClocknestGames.Library.Utils;
using ClocknestGames.Library.Editor;
using PublisherSDK;
using Publisher.Advertisements;

namespace ClocknestGames.Game.Core
{
    // WARNING: CHANGE BELOW KEYS WITH CAUTION!
    public static class RemoteConfigKeys
    {
        // INFO: _F suffix on keys defines those keys are string formatted.

        // GAME SETTING
        public const string GameSetting_RateUsTime = "GameSetting_RateUsTime";
        public const string GameSetting_GasPriceAutoAdjustTime = "GameSetting_GasPriceAutoAdjustTime";
        // public const string GameSetting_CeoTutorialShowDelay = "GameSetting_CeoTutorialShowDelay";
        public const string GameSetting_CeoSpawnOnStarCountReached = "GameSetting_CeoSpawnOnStarCountReached";

        public const string GameSetting_PlayerMoneyOnGameStart = "GameSetting_PlayerMoneyOnGameStart";
        public const string GameSetting_PlayerRunSpeed = "GameSetting_PlayerRunSpeed";
        public const string GameSetting_CustomerInVehicleRunSpeed = "GameSetting_CustomerInVehicleRunSpeed";
        public const string GameSetting_GasTruckMoveSpeed = "GameSetting_GasTruckMoveSpeed";

        public const string GameSetting_PlayerHoverboardAdditionalSpeed = "GameSetting_PlayerHoverboardAdditionalSpeed";

        public const string GameSetting_DoVehiclesHaveSameStartGasAmount = "GameSetting_DoVehiclesHaveSameStartGasAmount";
        public const string GameSetting_DoVehiclesHaveSameGasCapacity = "GameSetting_DoVehiclesHaveSameGasCapacity";
        public const string GameSetting_VehicleStartGasAmount = "GameSetting_VehicleStartGasAmount";
        public const string GameSetting_VehicleGasCapacity = "GameSetting_VehicleGasCapacity";

        public const string GameSetting_IsVehicleVIPGasCapacityDefined = "GameSetting_IsVehicleVIPGasCapacityDefined";
        public const string GameSetting_VehicleVIPStartGasAmount = "GameSetting_VehicleVIPStartGasAmount";
        public const string GameSetting_VehicleVIPGasCapacity = "GameSetting_VehicleVIPGasCapacity";
        public const string GameSetting_VehicleVIPGasFillStarReward = "GameSetting_VehicleVIPGasFillStarReward";
        public const string GameSetting_VehicleVIPGasFillWaitTime = "GameSetting_VehicleVIPGasFillWaitTime";
        public const string GameSetting_VehicleVIPPlayerFillsVIPGas = "GameSetting_VehicleVIPPlayerFillsVIPGas";
        public const string GameSetting_VehicleVIPRewardButtonGivesMoney = "GameSetting_VehicleVIPRewardButtonGivesMoney";

        public const string GameSetting_VehicleVIPGasPumpSplitMoneyCountScaler = "GameSetting_VehicleVIPGasPumpSplitMoneyCountScaler";
        public const string GameSetting_VehicleVIPGasPumpMoneyScaler = "GameSetting_VehicleVIPGasPumpMoneyScaler";

        public const string GameSetting_VehicleVIPSpawnOrder = "GameSetting_VehicleVIPSpawnOrder";
        public const string GameSetting_VehicleVIPSpawnForEveryXPump = "GameSetting_VehicleVIPSpawnForEveryXPump";
        public const string GameSetting_VehicleVIPSpawnAfterPumpCount = "GameSetting_VehicleVIPSpawnAfterPumpCount";
        public const string GameSetting_VehicleVIPWaitInflationTutorialToSpawnVIP = "GameSetting_VehicleVIPWaitInflationTutorialToSpawnVIP";
        public const string GameSetting_VehicleVIPStartSpawningVIPAfterInflationTutorialDelay = "GameSetting_VehicleVIPStartSpawningVIPAfterInflationTutorialDelay";

        public const string GameSetting_DisplayAchievementOnScreen = "GameSetting_DisplayAchievementOnScreen";

        // ANIMATION CURVES
        public const string GameSetting_AnimationCurve_F = "{0}_AnimationCurve";

        // OFFER
        public const string Offer_Profit_ShowOfferAfterDuration = "Offer_Profit_ShowOfferAfterDuration";
        public const string Offer_Profit_OfferTimeOut = "Offer_Profit_OfferTimeOut";
        public const string Offer_Profit_OfferActiveDuration = "Offer_Profit_OfferActiveDuration";
        public const string Offer_Profit_OfferAmount = "Offer_Profit_OfferAmount";

        // INTERSTITIAL
        public const string Interstitial_FirstInterstitialTime = "Interstitial_FirstInterstitialTime";
        public const string Interstitial_InterstitialInterval = "Interstitial_InterstitialInterval";
        public const string Interstitial_InterstitialResetTime = "Interstitial_InterstitialResetTime";
        public const string Interstitial_DoesIntersitatialTimerKeepGoingBeforeReset = "Interstitial_DoesIntersitatialTimerKeepGoingBeforeReset";

        // MONEY ZONE
        public const string MoneyZone_AtStart_MoneyCount = "MoneyZone_AtStart_MoneyCount";
        public const string MoneyZone_AtStart_MoneyAmountForEach = "MoneyZone_AtStart_MoneyAmountForEach";

        // BUYABLE ZONE
        public const string BuyableZone_GeneralStarCount_F = "{0}_StarCount";  // Ex: Zone_GasPump_StarCount
        public const string BuyableZone_UseOwnStarCount_F = "BuyableZone_UseOwnStarCount_Id_{0}";
        public const string BuyableZone_RewardStarCount_F = "BuyableZone_RewardStarCount_Id_{0}";

        public const string BuyableZone_ActivateTimer_F = "{0}_ActivateTimer";

        public const string UnlockedZone_MaxMoneySplitCount_F = "{0}_MaxMoneySplitCount";
        public const string UnlockedZone_MoneySplitAmount_F = "{0}_MoneySplitAmount";


        public const string BuyableZone_IsRewarded_F = "BuyableZone_IsRewarded_Id_{0}";     // VER_SUP_1.00(9)-iOS: This area is not used after this build. Instead, BuyableZone_PayType_F is used.
        public const string BuyableZone_GeneralPayType_F = "{0}_PayType";  // Ex: Zone_GasPump_PayType
        public const string BuyableZone_UseOwnPayType_F = "BuyableZone_UseOwnPayType_Id_{0}";
        public const string BuyableZone_PayType_F = "BuyableZone_PayType_Id_{0}";

        public const string BuyableZone_BuyCost_F = "BuyableZone_BuyCost_Id_{0}";
        public const string BuyableZone_BuyPaySpeed_F = "BuyableZone_BuyPaySpeed_Id_{0}";

        public const string MoneyOfferer_MoneyClaimDelayTime = "MoneyOfferer_MoneyClaimDelayTime";

        // AIR ZONE
        public const string AirZone_MoneyGenerateTime = "AirZone_MoneyGenerateTime";

        // VENDING MACHINE ZONE
        public const string VendingMachineZone_MoneyGenerateTime = "VendingMachineZone_MoneyGenerateTime";
        public const string VendingMachineZone_ItemCountPerBox = "VendingMachineZone_ItemCountPerBox";

        // GAS PUMP ZONE
        public const string GasPumpZone_VehicleMoneySplitMoneyAmount = "GasPumpZone_VehicleMoneySplitMoneyAmount";  // VER_SUP_1.00(9)-iOS: This area is not used after this build. Instead, UnlockedZone_MoneySplitAmount_F is used.
        public const string GasPumpZone_VehicleMoneySplitMaxCount = "GasPumpZone_VehicleMoneySplitMaxCount";        // VER_SUP_1.00(9)-iOS: This area is not used after this build. Instead, UnlockedZone_MaxMoneySplitCount_F is used.

        public const string GasPumpZone_PumpSpeedToVehicle = "GasPumpZone_PumpSpeedToVehicle";

        // UPGRADES
        public const string Upgrades = "Upgrades";

        // STAFF
        public const string Staff_GasPump_StartWorkingBelowGasPercentage = "Staff_GasPump_StartWorkingBelowGasPercentage";
        public const string Staff_General_CanBeActivated = "Staff_General_CanBeActivated_{0}";
        public const string Staff_CanBeActivated_F = "Staff_CanBeActivated_{0}";

        // EQUIP ITEM
        public const string EquipItem_ActiveTime = "{0}_EquipItem_ActiveTime";
        public const string EquipItem_RechargeTime = "{0}_EquipItem_RechargeTime";

        // GAS TANK
        public const string GasTank_StartGasAmount_F = "GasTank_StartGasAmount_{0}";
    }

    public static class EventKeys
    {
        public const string Game_Last_Activity = "game_last_activities";

        public const string Area_Unlocked = "area_unlocked";
        public const string Area_Changed = "area_changed";

        public const string Journey_Started = "journey_started";
        public const string Journey_Completed = "journey_completed";

        public const string Work_Started = "work_started";
        public const string Work_Cancelled = "work_cancelled";
        public const string Work_Completed = "work_completed";

        public const string Button_TapStarted = "button_tap_started";
        public const string Button_TapStopped = "button_tap_stopped";
        public const string Popup_Shown = "popup_shown";
        public const string Popup_Closed = "popup_closed";

        public const string Zone_Changed = "zone_changed";

        public const string Upgraded = "upgraded";

        public const string Activity_GasTruck_Call = "activity_gastruckcall";

        public const string Level_Main_Opened = "level_opened";

        public const string Reward_Requested = "rw_requested";
        public const string Reward_RequestFailed = "rw_request_failed";
        public const string Reward_Started = "rw_started";
        public const string Reward_Completed = "rw_completed";
        public const string Reward_Failed = "rw_failed";

        public const string ADS_Watched_PREF = "ads_watched";
        public const string ADS_Requested_PREF = "ads_requested";

        public const string Ceo_Show_Started = "ceo_show_started";
        public const string Ceo_Show_Completed = "ceo_show_completed";
    }

    public static class EventParamKeys
    {
        public const string AreaName = "area_name";
        public const string JourneyId = "journey_id";

        public const string LevelId = "level_id";
        public const string LevelName = "level_name";
        public const string LevelSceneId = "level_scene_id";
        public const string Area_Unlocked = "area_unlocked";
        public const string Area_Id = "area_id";
        public const string Area_ProgressId = "area_progress_id";

        public const string WorkName = "work_name";
        public const string WorkName_GasHoseFromTank = "gashose_fromtank";
        public const string WorkName_GasHoseFromTruck = "gashose_fromtruck";
        public const string WorkName_GasHoseFromPump = "gashose_frompump";
        public const string WorkName_Mechanic = "mechanic";
        public const string WorkName_VendingMachine = "vending_machine";

        public const string BuildingId = "building_id";
        public const string Duration = "duration";

        public const string Activities = "activities";
        public const string Activity = "activity";
        public const string Source = "source";

        public const string Zone_New = "new_zone";

        public const string UpgradeName = "name";
        public const string UpgradeCostType = "cost_type";
        public const string UpgradeCost = "cost";
        public const string Balance = "balance";

        public const string Activity_TruckCall = "gas_truck_called";
        public const string BaseGasPrice = "base_gas_price";
        public const string PlayerGasPrice = "player_gas_price";
        public const string Pay_Type = "pay_type";

        public const string Reward_Action = "rw_action";

        public const string Inflation_Time = "inflation_time";
    }

    public enum EventWorkStatus
    {
        Started = 0,
        Cancelled = 1,
        Completed = 2
    }

    // WARNING: If any value is added or removed, do not forget to update related methods in this script.
    public enum EventWorkType
    {
        GasHoseFromTank = 0,
        GasHoseFromTruck = 1,
        Mechanic = 2,
        VendingMachine = 3,
        GasTruckCall = 4,
        GasHoseFromPump = 5
    }

    public struct SdkAdsBannerEvent
    {
        public bool IsShowing;

        public SdkAdsBannerEvent(bool isShowing)
        {
            IsShowing = isShowing;
        }
    }

    public struct SdkPauseEvent
    {
        public bool IsPaused;

        public SdkPauseEvent(bool isPaused)
        {
            IsPaused = isPaused;
        }
    }

    public interface IInterstitialBlocker { }


    [System.Serializable]
    public enum SDKAdsStatus
    {
        NotAvailable = 0,
        Available = 1,
        Showing = 2
    }

    [System.Serializable]
    public enum SDKAdsResponseType
    {
        Success = 1,
        Fail = 2
    }

    [System.Serializable]
    public enum SDKAdsType
    {
        Banner = 0,
        Interstitial = 1,
        Reward = 2
    }

    public enum SdkEventAdsStatus
    {
        Requested = 0,
        RequestFailed = 1,
        Started = 2,
        Completed = 3,
        Failed = 4
    }

    public interface SDKAdsRequester
    {

    }

    public class SDKAdsRequest
    {
        public string RequestName;
        public SDKAdsRequester Requester;
        public Action<SDKAdsResponseType> OnComplete;
        public bool IsFakeRequest = false;
    }

    public struct SdkManagerRewardAdAvailabilityEvent
    {
        public bool CanShow;

        public SdkManagerRewardAdAvailabilityEvent(bool canShow)
        {
            CanShow = canShow;
        }
    }

    public struct SdkNoAdsBoughtEvent
    {
        public bool IsNoAdsBought;

        public SdkNoAdsBoughtEvent(bool isNoAdsBought)
        {
            IsNoAdsBought = isNoAdsBought;
        }
    }

    [System.Serializable]
    public class SdkManagerLastActivityItem
    {
        public string Name;
        public string CurrentTime;
    }

    [System.Serializable]
    public class SdkManagerLastActivity
    {
        public string SessionId;
        public string SessionDuration;
        public List<SdkManagerLastActivityItem> Events;
        public List<SdkManagerLastActivityItem> Areas;
        
        private int _maxEventCount;
        private int _maxAreaCount;

        public SdkManagerLastActivity(string sessionId, int maxEventCount, int maxAreaCount)
        {
            SessionId = sessionId;
            Events = new List<SdkManagerLastActivityItem>(maxEventCount);
            Areas = new List<SdkManagerLastActivityItem>(maxAreaCount);

            _maxEventCount = maxEventCount;
            _maxAreaCount = maxAreaCount;
        }

        public void AddEvent(string eventNameWithDesc, double currentTime)
        {
            bool removeLastEvent = Events.Count >= _maxEventCount;

            Events.Insert(0, new SdkManagerLastActivityItem { Name = eventNameWithDesc, CurrentTime = GetTimeFromSeconds(currentTime) });
            if (removeLastEvent)
                Events.RemoveAt(Events.Count - 1);
        }

        public void AddArea(string areaName, double currentTime)
        {
            bool removeLastArea = Areas.Count >= _maxAreaCount;

            Areas.Insert(0, new SdkManagerLastActivityItem { Name = areaName, CurrentTime = GetTimeFromSeconds(currentTime) });
            if (removeLastArea)
                Areas.RemoveAt(Areas.Count - 1);
        }

        public void SetSessionDuration(double duration)
        {
            SessionDuration = GetTimeFromSeconds(duration);
        }

        public bool HasData()
        {
            return Events.Count > 0 || Areas.Count > 0;
        }

        public void ResetActivity()
        {
            Events.Clear();
            Areas.Clear();
        }

        private string GetTimeFromSeconds(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"dd\.hh\:mm\:ss");
        }
    }

    public class SdkManager : PersistentSingleton<SdkManager>, EventListener<LevelEvent>
    {

#if UNITY_IPHONE
        private readonly string _appKey = "*********";
#elif UNITY_ANDROID
        private readonly string _appKey = "*********";
#elif UNITY_EDITOR
        private readonly string _appKey = "";
#endif

		[Header("Version")]
        [SerializeField] private string _versionIOS = "v1.00";
        [SerializeField] private string _versionAndroid = "v1.00";

        [Header("Interstitial")]
        [SerializeField] private float _firstInterstitialTime = 120f;       // In seconds
        [SerializeField] private float _interstitialInterval = 120f;        // In seconds
        [SerializeField] private float _interstitialResetTime = 80f;        // In seconds.
        [SerializeField] private bool _doesIntersitatialTimerKeepGoingBeforeReset = true;
        [SerializeField] private float _rateUsTime = 90f;                   // In seconds

        [Header("Status")]
        [SerializeField, ReadOnly] private SDKAdsStatus _rewardedAdsStatus = SDKAdsStatus.NotAvailable;
        [SerializeField, ReadOnly] private SDKAdsStatus _interstitialStatus = SDKAdsStatus.NotAvailable;

        [Header("Remote Config")]
        [SerializeField] private bool _isRemoteConfigEnabled = true;

#if UNITY_IPHONE
        public string AppVersion => _versionIOS;
#else
        public string AppVersion => _versionAndroid;
#endif

        public SDKAdsStatus RewardedAdsStatus { get => _rewardedAdsStatus; set => _rewardedAdsStatus = value; }
        public SDKAdsStatus InterstitialStatus { get => _interstitialStatus; set => _interstitialStatus = value; }
        public bool CanShowRewardedAds { get; private set; } = false;
        public SDKAdsRequest CurrentAdsRequest { get; private set; } = null;

        public bool IsPaused { get; private set; } = false;
        public bool IsSDKAdsInitialized { get; private set; } = false;
        public bool IsSDKTimerActive { get; private set; } = false;
        public bool IsAdLevelOpened { get; private set; } = false;
        public float SDKTimer { get; private set; } = 0f;
        public float SDKTimerSaved { get; private set; } = 0f;
        public bool IsFirstInterstitialShown { get; private set; } = false;
        public float InterstitialTimer { get; private set; } = 0f;
        public bool IsRateUsShown { get; private set; } = false;
        public int InterstitialIndex { get; private set; } = 0;
        public bool IsSdkLoadedBefore { get; private set; } = false;
        public bool IsNoAdsBought { get; private set; } = false;

        private List<IInterstitialBlocker> _interstitialBlockers = new List<IInterstitialBlocker>();
        private float _interstitialTargetInterval;

        private SdkManagerLastActivity _sdkManagerLastActivity;
        private double _sdkManagerLastActivitySessionTime = 0f;

        private const int AD_CHECK_INTERVAL = 60;
        private bool _canCheckAds => Time.frameCount % AD_CHECK_INTERVAL == 0;

        protected override void Awake()
        {
            base.Awake();

            if (!enabled) return;

            _sdkManagerLastActivity = new SdkManagerLastActivity(Guid.NewGuid().ToString(), 5, 5);

            InterstitialIndex = ProgressManager.Instance.GetSdkDataInterstitialIndex();
            IsSdkLoadedBefore = ProgressManager.Instance.GetSdkDataIsSdkLoadedBefore();

            RLAdvertisementManager.Instance.init(_appKey);
            RLAdvertisementManager.OnPublisherAdsSdkInitializedEvent += OnPublisherAdsSdkInitializedEvent;
            RLAdvertisementManager.Instance.rewardedAdResultCallback += RewardedAdResultCallback;

            // Banner
            RLAdvertisementManager.OnPublisherAdsAdLoadedEvent += OnPublisherAdsAdLoadedEvent;
            RLAdvertisementManager.OnPublisherAdsAdFailedEvent += OnPublisherAdsAdFailedEvent;
            RLAdvertisementManager.OnPublisherAdsAdClickedEvent += OnPublisherAdsAdClickedEvent;
            // RLAdvertisementManager.OnPublisherAdsAdExpandedEvent += OnPublisherAdsAdExpandedEvent;
            // RLAdvertisementManager.OnPublisherAdsAdCollapsedEvent += OnPublisherAdsAdCollapsedEvent;

            // Interstitial
            RLAdvertisementManager.OnPublisherAdsInterstitialLoadedEvent += OnPublisherAdsInterstitialLoadedEvent;
            RLAdvertisementManager.OnPublisherAdsInterstitialFailedEvent += OnPublisherAdsInterstitialFailedEvent;
            RLAdvertisementManager.OnPublisherAdsInterstitialDismissedEvent += OnPublisherAdsInterstitialDismissedEvent;
            // RLAdvertisementManager.OnPublisherAdsInterstitialExpiredEvent += OnPublisherAdsInterstitialExpiredEvent;
            RLAdvertisementManager.OnPublisherAdsInterstitialShownEvent += OnPublisherAdsInterstitialShownEvent;
            RLAdvertisementManager.OnPublisherAdsInterstitialClickedEvent += OnPublisherAdsInterstitialClickedEvent;

            // Rewarded Ads
            RLAdvertisementManager.OnPublisherAdsRewardedVideoClickedEvent += OnPublisherAdsRewardedVideoClickedEvent;
            // RLAdvertisementManager.OnPublisherAdsRewardedVideoLoadedEvent += OnPublisherAdsRewardedVideoLoadedEvent;
            // RLAdvertisementManager.OnPublisherAdsRewardedVideoFailedEvent += OnPublisherAdsRewardedVideoFailedEvent;
            // Below events are not needed as rewardedAdResultCallback is called instead.
            // RLAdvertisementManager.OnPublisherAdsRewardedVideoClosedEvent += OnPublisherAdsRewardedVideoClosedEvent;
            // RLAdvertisementManager.OnPublisherAdsRewardedVideoFailedToPlayEvent += OnPublisherAdsRewardedVideoFailedToPlayEvent;
            // RLAdvertisementManager.OnPublisherAdsRewardedVideoReceivedRewardEvent += OnPublisherAdsRewardedVideoReceivedRewardEvent;
            RLAdvertisementManager.OnPublisherAdsRewardedVideoLeavingApplicationEvent += OnPublisherAdsRewardedVideoLeavingApplicationEvent;
            RLAdvertisementManager.OnPublisherAdsRewardedVideoShownEvent += OnPublisherAdsRewardedVideoShownEvent;

            IsFirstInterstitialShown = ProgressManager.Instance.GetSdkDataFirstInterstitialShown();
            IsRateUsShown = ProgressManager.Instance.GetSdkDataIsRateUsShown();
            SDKTimerSaved = ProgressManager.Instance.GetSdkDataSdkTime();
            IsNoAdsBought = ProgressManager.Instance.GetSdkDataIsNoAdsBought();
        }

        private void Start()
        {
            _firstInterstitialTime = RemoteConfigGetFloat(RemoteConfigKeys.Interstitial_FirstInterstitialTime, _firstInterstitialTime);
            _interstitialInterval = RemoteConfigGetFloat(RemoteConfigKeys.Interstitial_InterstitialInterval, _interstitialInterval);
            _interstitialResetTime = RemoteConfigGetFloat(RemoteConfigKeys.Interstitial_InterstitialResetTime, _interstitialResetTime);
            _doesIntersitatialTimerKeepGoingBeforeReset = RemoteConfigGetBool(RemoteConfigKeys.Interstitial_DoesIntersitatialTimerKeepGoingBeforeReset, _doesIntersitatialTimerKeepGoingBeforeReset);
            _rateUsTime = RemoteConfigGetFloat(RemoteConfigKeys.GameSetting_RateUsTime, _rateUsTime);

            _interstitialTargetInterval = _interstitialInterval;
        }

        private void Update()
        {
            if (!IsSDKTimerActive) return;

            SDKTimer += Time.deltaTime;
            SDKTimerSaved += Time.deltaTime;

            ProgressManager.Instance.SetSdkDataSdkTime(SDKTimerSaved);

            // Increase interstitial timer if no ads showing.
            if (!IsAnyAdShowing())
                InterstitialTimer += Time.deltaTime;

            // If any ads previously shown or failed, their status will be set to NotAvailable in those events.
            // So we recover from that status to available if possible.
            if (_canCheckAds && IsSDKAdsInitialized)
            {
                if (RewardedAdsStatus != SDKAdsStatus.Showing)
                {
                    if (RLAdvertisementManager.Instance.isRewardedVideoAvailable())
                        RewardedAdsStatus = SDKAdsStatus.Available;
                    else
                        RewardedAdsStatus = SDKAdsStatus.NotAvailable;
                }

                if (InterstitialStatus != SDKAdsStatus.Showing)
                {
                    if (RLAdvertisementManager.Instance.isInterstitialReady())
                        InterstitialStatus = SDKAdsStatus.Available;
                    else
                        InterstitialStatus = SDKAdsStatus.NotAvailable;
                }
            }

            // Check if we should show first interstitial.
            if (!IsFirstInterstitialShown && InterstitialTimer >= _firstInterstitialTime)
            {
                if (ShowInterstitial())
                {
                    IsFirstInterstitialShown = true;
                    ProgressManager.Instance.SetSdkDataFirstInterstitialShown(IsFirstInterstitialShown);
                }
            }
            // Check if interstitial will be shown.
            else if (IsFirstInterstitialShown && InterstitialTimer >= _interstitialTargetInterval)
            {
                ShowInterstitial();
            }

            // Show rate us popup if enough time has passed.
            if (!IsRateUsShown && SDKTimer >= _rateUsTime)
            {
                ShowRateUs();

                IsRateUsShown = true;
                ProgressManager.Instance.SetSdkDataIsRateUsShown(IsRateUsShown);
            }

            // Trigger rewarded ads availablity event to listeners.
            // So listeners can enable/disable free reward button or areas accordingly.
            if (IsSDKAdsInitialized)
            {
                bool canShowAdThisFrame = CanShowAd(SDKAdsType.Reward, out string rewadAdFailReason);
                if (CanShowRewardedAds && !canShowAdThisFrame)
                {
                    CanShowRewardedAds = false;
                    EventManager.TriggerEvent(new SdkManagerRewardAdAvailabilityEvent(false));
                }
                else if (!CanShowRewardedAds && canShowAdThisFrame)
                {
                    CanShowRewardedAds = true;
                    EventManager.TriggerEvent(new SdkManagerRewardAdAvailabilityEvent(true));
                }
            }
        }

        #region Remote Config
        public string RemoteConfigGet(string key, string defaultValue)
        {
            if (!_isRemoteConfigEnabled) return defaultValue;

            if (RemoteConfig.GetInstance().GetBool($"{AppVersion}_IsEnabled_{key}", false))
                return RemoteConfig.GetInstance().Get($"{AppVersion}_{key}", defaultValue);

            return RemoteConfig.GetInstance().Get(key, defaultValue);
        }

        public int RemoteConfigGetInt(string key, int defaultValue)
        {
            if (!_isRemoteConfigEnabled) return defaultValue;

            if (RemoteConfig.GetInstance().GetBool($"{AppVersion}_IsEnabled_{key}", false))
                return RemoteConfig.GetInstance().GetInt($"{AppVersion}_{key}", defaultValue);

            return RemoteConfig.GetInstance().GetInt(key, defaultValue);
        }

        public float RemoteConfigGetFloat(string key, float defaultValue)
        {
            if (!_isRemoteConfigEnabled) return defaultValue;

            if (RemoteConfig.GetInstance().GetBool($"{AppVersion}_IsEnabled_{key}", false))
                return RemoteConfig.GetInstance().GetFloat($"{AppVersion}_{key}", defaultValue);

            return RemoteConfig.GetInstance().GetFloat(key, defaultValue);
        }

        public bool RemoteConfigGetBool(string key, bool defaultValue)
        {
            if (!_isRemoteConfigEnabled) return defaultValue;

            if (RemoteConfig.GetInstance().GetBool($"{AppVersion}_IsEnabled_{key}", false))
                return RemoteConfig.GetInstance().GetBool($"{AppVersion}_{key}", defaultValue);

            return RemoteConfig.GetInstance().GetBool(key, defaultValue);
        }
        #endregion

        private void ShowRateUs()
        {
            RateUsManager.Instance.Show((status) =>
            {
                Debug.Log(status ? "Rate Us shown." : "Rate Us could not shown!");
            });
        }

        #region Advertisement

        public bool IsAnyAdShowing()
        {
            return RewardedAdsStatus == SDKAdsStatus.Showing || InterstitialStatus == SDKAdsStatus.Showing;
        }

        public bool CanShowAd(SDKAdsType adsType, out string reason)
        {
            if (!IsSDKAdsInitialized)
            {
                reason = "SDK Ads is not initialized!";
                return false;
            }

            if (adsType == SDKAdsType.Reward)
            {
                if (_rewardedAdsStatus != SDKAdsStatus.Available)
                {
                    reason = "Rewarded Ads status is not available!: " + _rewardedAdsStatus.ToString();
                    return false;
                }

                if (_interstitialStatus == SDKAdsStatus.Showing)
                {
                    reason = "Interstitial is showing!";
                    return false;
                }

                if (!RLAdvertisementManager.Instance.isRewardedVideoAvailable())
                {
                    reason = "Rewarded Video is not ready!";
                    return false;
                }

                reason = string.Empty;
                return true;
            }

            if (adsType == SDKAdsType.Interstitial)
            {
                if (_interstitialStatus != SDKAdsStatus.Available)
                {
                    reason = "Interstitial status is not available!: " + _interstitialStatus.ToString();
                    return false;
                }

                if (_rewardedAdsStatus == SDKAdsStatus.Showing)
                {
                    reason = "Rewarded Ad is showing!";
                    return false;
                }

                if (!RLAdvertisementManager.Instance.isInterstitialReady())
                {
                    reason = "Interstitial is not ready!";
                    return false;
                }

                reason = string.Empty;
                return true;
            }

            /*
            if (adsType == SDKAdsType.Reward)
            {
                return IsSDKAdsInitialized
                    && _interstitialStatus == SDKAdsStatus.Available
                    && _rewardedAdsStatus == SDKAdsStatus.Available;
                    // && RLAdvertisementManager.Instance.isRewardedVideoAvailable();
            }

            if (adsType == SDKAdsType.Interstitial)
            {
                return IsSDKAdsInitialized
                        && _interstitialStatus == SDKAdsStatus.Available
                        && _rewardedAdsStatus == SDKAdsStatus.Available;
                        // && RLAdvertisementManager.Instance.isInterstitialReady();
            }
            */

            reason = string.Empty;
            return true;
        }

        /// <summary>
        /// Shows rewarded ad if possible.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>True if request is accepted.</returns>
        public bool ShowRewardedAd(SDKAdsRequest request)
        {
            Debug.Log("Rewarded Ad Show Request Received! :" + request.RequestName);

            SendEventAd(SdkEventAdsStatus.Requested, request.RequestName);

            if (request.IsFakeRequest || CanShowAd(SDKAdsType.Reward, out string reason))
            {
                SendEventAd(SdkEventAdsStatus.Started, request.RequestName);

                if (_doesIntersitatialTimerKeepGoingBeforeReset)
                {
                    _interstitialTargetInterval = (_interstitialTargetInterval - InterstitialTimer).ClampMin(_interstitialResetTime);
                }
                else
                {
                    float timeLeftForInterstitial = (_interstitialTargetInterval - InterstitialTimer).ClampMin(0);
                    _interstitialTargetInterval = timeLeftForInterstitial < _interstitialResetTime ? _interstitialResetTime : _interstitialInterval;
                }

                InterstitialTimer = 0f;
                CurrentAdsRequest = request;
                RewardedAdsStatus = SDKAdsStatus.Showing;

                Debug.Log("Showing rewarded ad.");
                if (!request.IsFakeRequest)
                    RLAdvertisementManager.Instance.showRewardedVideo();
                else
                    ProcessRewardedAdResult(RLRewardedAdResult.Finished);

                return true;
            }

            SendEventAd(SdkEventAdsStatus.RequestFailed, request.RequestName);

            Debug.Log("Rewarded Ad Request Failed. " + reason);
            return false;
        }

        private bool ShowInterstitial()
        {
            Debug.Log("Interstitial Show Request Received!");

            if (_interstitialBlockers.Count > 0)
            {
                Debug.Log($"Interstitial Request Failed. There is {_interstitialBlockers.Count} blocker(s)!");
                return false;
            }

            if (CanShowAd(SDKAdsType.Interstitial, out string reason))
            {
                _interstitialTargetInterval = _interstitialInterval;

                InterstitialTimer = 0f;
                InterstitialStatus = SDKAdsStatus.Showing;

                Debug.Log("Showing interstitial.");
                RLAdvertisementManager.Instance.showInterstitial();

                return true;
            }

            Debug.Log("Interstitial Request Failed. " + reason);
            return false;
        }

        private bool ShowBannerConditional()
        {
            if (!IsSDKAdsInitialized || !IsAdLevelOpened)
            {
                Debug.Log(!IsSDKAdsInitialized ? "Banner conditional show failed, SDK Ads not ready!" : "Banner conditional show failed, Level is not opened!");
                return false;
            }

            ShowBanner();
            return true;
        }

        private bool ShowBanner()
        {
            Debug.Log("Banner Show Request Received!");
            RLAdvertisementManager.Instance.showBanner();
            Debug.Log("Showing banner");

            EventManager.TriggerEvent(new SdkAdsBannerEvent(true));

            return true;
        }

        private bool LoadBanner()
        {
            Debug.Log("Loading banner.");
            RLAdvertisementManager.Instance.loadBanner();
            return true;
        }

        private void OnPublisherAdsSdkInitializedEvent()
        {
            Debug.Log("Publisher Ads SDK Initialized!");

            IsSDKAdsInitialized = true;

            LoadBanner();
        }

        private void SetInterstitialIndex(int index)
        {
            InterstitialIndex = index;
            ProgressManager.Instance.SetSdkDataInterstitialIndex(index);
        }

        private void ProcessRewardedAdResult(RLRewardedAdResult result)
        {
            var responseStatus = SDKAdsResponseType.Fail;
            if (result == RLRewardedAdResult.Finished)
            {
                responseStatus = SDKAdsResponseType.Success;
                SendEventAd(SdkEventAdsStatus.Completed, CurrentAdsRequest.RequestName);
            }
            else
            {
                responseStatus = SDKAdsResponseType.Fail;
                SendEventAd(SdkEventAdsStatus.Failed, CurrentAdsRequest.RequestName);
            }

            CurrentAdsRequest.OnComplete?.Invoke(responseStatus);
            CurrentAdsRequest = null;
            RewardedAdsStatus = SDKAdsStatus.NotAvailable;
        }

        #region RLAdvertisementManager Rewarded Ads
        private void RewardedAdResultCallback(RLRewardedAdResult result)
        {
            ProcessRewardedAdResult(result);

            UnPause();
        }

        private void OnPublisherAdsRewardedVideoShownEvent()
        {
            Pause();
        }

        /*
        private void OnPublisherAdsRewardedVideoFailedToPlayEvent()
        {

        }

        private void OnPublisherAdsRewardedVideoClosedEvent()
        {

        }

        private void OnPublisherAdsRewardedVideoReceivedRewardEvent(IronSourcePlacement obj)
        {

        }

        private void OnPublisherAdsRewardedVideoLoadedEvent(string obj)
        {

        }

        private void OnPublisherAdsRewardedVideoFailedEvent(string arg1, string arg2)
        {

        }
        */

        private void OnPublisherAdsRewardedVideoLeavingApplicationEvent(string obj)
        {

        }

        private void OnPublisherAdsRewardedVideoClickedEvent()
        {

        }
        #endregion

        #region RLAdvertisementManager Interstitials
        private void OnPublisherAdsInterstitialLoadedEvent(string obj)
        {

        }

        private void OnPublisherAdsInterstitialFailedEvent(IronSourceError obj)
        {
            /*
            InterstitialStatus = SDKAdsStatus.NotAvailable;
            StartJourney(InterstitialIndex + 1);
            UnPause();
            */
        }

        private void OnPublisherAdsInterstitialShownEvent()
        {
            CompleteJourney();
            Pause();
        }

        private void OnPublisherAdsInterstitialDismissedEvent()
        {
            InterstitialStatus = SDKAdsStatus.NotAvailable;
            StartJourney(InterstitialIndex + 1);
            UnPause();
        }

        /*
        private void OnPublisherAdsInterstitialExpiredEvent(string obj)
        {

        }
        */

        private void OnPublisherAdsInterstitialClickedEvent()
        {

        }
        #endregion

        #region RLAdvertisementManager Banners
        /*
        private void OnPublisherAdsAdCollapsedEvent(string obj)
        {

        }

        private void OnPublisherAdsAdExpandedEvent(string obj)
        {

        }
        */

        private void OnPublisherAdsAdClickedEvent()
        {

        }

        private void OnPublisherAdsAdLoadedEvent()
        {
            Debug.Log("Banner loaded.");
            ShowBannerConditional();
        }

        private void OnPublisherAdsAdFailedEvent(string obj)
        {
            Debug.Log("Banner load failed! Reason: " + obj + ", trying again.");
            LoadBanner();
        }
        #endregion

        #endregion

        #region Events
        private void SendEvent(string eventName, Params eventParams = null)
        {
            PublisherAds.Event(eventName, LevelManager.LevelIndex, eventParams);

            // Debug.Log("Event: " + eventName);
        }

        private void SendEvent(string eventName, string eventDesc, Params eventParams = null)
        {
            SendEvent(eventName, eventParams);

            _sdkManagerLastActivity.AddEvent($"{eventName}$&${eventDesc}", Time.timeSinceLevelLoadAsDouble);
            // Debug.Log("Event: " + eventName);
        }

        public void SendEventWork(EventWorkType workType, EventWorkStatus workStatus)
        {
            string eventName;
            if (workStatus == EventWorkStatus.Started) eventName = EventKeys.Work_Started;
            else if (workStatus == EventWorkStatus.Cancelled) eventName = EventKeys.Work_Cancelled;
            else if (workStatus == EventWorkStatus.Completed) eventName = EventKeys.Work_Completed;
            else throw new Exception("Work status is not implemented! :" + workStatus.ToString());

            string workName;
            if (workType == EventWorkType.GasHoseFromTank) workName = EventParamKeys.WorkName_GasHoseFromTank;
            else if (workType == EventWorkType.GasHoseFromTruck) workName = EventParamKeys.WorkName_GasHoseFromTruck;
            else if (workType == EventWorkType.Mechanic) workName = EventParamKeys.WorkName_Mechanic;
            else if (workType == EventWorkType.VendingMachine) workName = EventParamKeys.WorkName_VendingMachine;
            else if (workType == EventWorkType.GasTruckCall) workName = EventParamKeys.WorkName_GasHoseFromTruck;
            else if (workType == EventWorkType.GasHoseFromPump) workName = EventParamKeys.WorkName_GasHoseFromPump;
            else throw new Exception("Work type is not implemented! :" + workType.ToString());

            var eventParams = GetDefaultParams()
                                    .Set(EventParamKeys.WorkName, workName);
            SendEvent(eventName, workName, eventParams);

            // Debug.Log($"Event Send: {eventName}, Work: {workName}");
        }

        public void SendEventJourneyStarted()
        {
            var eventParams = GetDefaultParams();
            SendEvent(EventKeys.Journey_Started, InterstitialIndex.ToString(), eventParams);

            Debug.Log($"Event Send: {EventKeys.Journey_Started}, Id: {InterstitialIndex}");
        }

        public void SendEventJourneyCompleted()
        {
            var eventParams = GetDefaultParams();
            SendEvent(EventKeys.Journey_Completed, InterstitialIndex.ToString(), eventParams);

            Debug.Log($"Event Send: {EventKeys.Journey_Completed}, Id: {InterstitialIndex}");
        }

        public void SendEventAreaUnlocked(string areaName)
        {
            var eventParams = GetDefaultParams();
            SendEvent(EventKeys.Area_Unlocked, areaName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Area_Unlocked}, Source: {areaName}");
        }

        public void SendEventAreaChanged(string areaName)
        {
            // Commented below after gm request.
            // var eventParams = GetDefaultParams();
            // SendEvent(EventKeys.Area_Changed, eventParams);

            _sdkManagerLastActivity.AddArea($"{areaName}", Time.timeSinceLevelLoadAsDouble);

            // Debug.Log($"Event Send: {EventKeys.Area_Changed}, Source: {areaName}");
        }

        public void SendEventButtonTapped(string activityName)
        {
            SendEventButtonTapStarted(activityName);
            SendEventButtonTapStopped(activityName, 0f);
        }

        public void SendEventButtonTapStarted(string activityName)
        {
            var eventParams = GetDefaultParams()
                                .Set(EventParamKeys.Activity, activityName);
            SendEvent(EventKeys.Button_TapStarted, activityName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Button_TapStarted}, Source: {activityName}");
        }

        public void SendEventButtonTapStopped(string activityName, float duration)
        {
            var eventParams = GetDefaultParams()
                                .Set(EventParamKeys.Activity, activityName)
                                .Set(EventParamKeys.Duration, duration);
            SendEvent(EventKeys.Button_TapStopped, activityName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Button_TapStopped}, Source: {activityName}");
        }

        public void SendEventPopupShown(string activityName)
        {
            var eventParams = GetDefaultParams()
                    .Set(EventParamKeys.Activity, activityName);
            SendEvent(EventKeys.Popup_Shown, activityName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Popup_Shown}, Popup: {activityName}");
        }

        public void SendEventPopupClosed(string activityName, float timePassed)
        {
            var eventParams = GetDefaultParams()
                    .Set(EventParamKeys.Activity, activityName)
                    .Set(EventParamKeys.Duration, timePassed.ToString("F1"));
            SendEvent(EventKeys.Popup_Closed, activityName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Popup_Closed}, Popup: {activityName}");
        }

        public void SendEventZoneChanged(string zoneName)
        {
            var eventParams = GetDefaultParams()
                    .Set(EventParamKeys.Zone_New, zoneName);
            SendEvent(EventKeys.Zone_Changed, zoneName, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Zone_Changed}, New Zone: {zoneName}");
        }

        public void SendEventUpgrade(string type, string costType, long cost, long balance, string source)
        {
            var eventParams = GetDefaultParams()
                    .Set(EventParamKeys.Source, source)
                    .Set(EventParamKeys.UpgradeName, type)
                    .Set(EventParamKeys.UpgradeCost, cost)
                    .Set(EventParamKeys.Balance, balance);
            SendEvent(EventKeys.Upgraded, source, eventParams);
        }

        public void SendEventTruckCall(bool isFree, float basePrice, float gasPrice)
        {
            string payType = isFree ? "free" : "paid";
            var eventParams = GetDefaultParams()
                    .Set(EventParamKeys.Pay_Type, payType)
                    .Set(EventParamKeys.BaseGasPrice, basePrice)
                    .Set(EventParamKeys.PlayerGasPrice, gasPrice);
            SendEvent(EventKeys.Activity_GasTruck_Call, payType, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Activity_GasTruck_Call}, Is Free: {isFree}, Base Price: {basePrice}, Gas Price: {gasPrice}");
        }

        public void SendEventLevelOpened(int index)
        {
            var eventParams = Params.New()
                        .Set(EventParamKeys.LevelId, index);
            SendEvent(EventKeys.Level_Main_Opened, index.ToString(), eventParams);
        }

        public void SendEventLevelStarted(int levelIndex, string areaName, int progressId, int levelSceneId)
        {
            var eventParams = GetDefaultParams()
                .Set(EventParamKeys.Area_Unlocked, areaName)
                .Set(EventParamKeys.Area_ProgressId, progressId)
                .Set(EventParamKeys.LevelSceneId, levelSceneId);

			PublisherAds.LevelStarted(levelIndex, eventParams);

            // Debug.Log($"Event Send: {EventKeys.Area_Unlocked}, Source: {areaName}");
        }

        // adName is like: rw_gas_truck_fill
        public void SendEventAd(SdkEventAdsStatus status, string adName)
        {
            string eventName = null;
            switch (status)
            {
                case SdkEventAdsStatus.Requested: eventName = EventKeys.Reward_Requested; break;
                case SdkEventAdsStatus.RequestFailed: eventName = EventKeys.Reward_RequestFailed; break;
                case SdkEventAdsStatus.Started: eventName = EventKeys.Reward_Started; break;
                case SdkEventAdsStatus.Completed: eventName = EventKeys.Reward_Completed; break;
                case SdkEventAdsStatus.Failed: eventName = EventKeys.Reward_Failed; break;
            }

            if (string.IsNullOrEmpty(eventName))
            {
                Debug.LogError("Event Name for ad is not exists! : " + status.ToString());
                return;
            }

            // Send event requested, completed or failed event with requester name.
            var eventParams = GetDefaultParams()
                .Set(EventParamKeys.Reward_Action, adName);
            SendEvent(eventName, eventParams);

            if (status == SdkEventAdsStatus.Requested)
            {
                // EventName is like: ads_requested_rw_gas_truck_fill
                eventParams = GetDefaultParams();
                eventName = $"{EventKeys.ADS_Requested_PREF}_{adName}";

                SendEvent(eventName, string.Empty, eventParams);
            }
            else if (status == SdkEventAdsStatus.Completed)
            {
                // EventName is like: ads_watched_rw_gas_truck_fill
                eventParams = GetDefaultParams();
                eventName = $"{EventKeys.ADS_Watched_PREF}_{adName}";

                SendEvent(eventName, string.Empty, eventParams);
            }
        }

        public void SendEventCeoShown(bool isStarted, float time)
        {
            string eventName = isStarted ? EventKeys.Ceo_Show_Started : EventKeys.Ceo_Show_Completed;
            var eventParams = Params.New()
                        .Set(EventParamKeys.Inflation_Time, time.ToString("F0"));
            SendEvent(eventName, string.Empty, eventParams);
        }

        private Params GetDefaultParams()
        {
            return Params.New()
                        .Set(EventParamKeys.AreaName, StationManager.Instance.CurrentAreaName)
                        .Set(EventParamKeys.JourneyId, InterstitialIndex);
        }

        private void SendTransaction(string eventName, long amount, long finalAmount, string source)
        {
			PublisherAds.Transaction(eventName, LevelManager.LevelIndex, amount, finalAmount, source);
        }

        public void SendEventCashTransaction(string currency, long amount, long finalAmount, string source)
        {
            SendTransaction(currency, amount, finalAmount, source);

            // Debug.Log($"Event Transaction : {currency}, {source}, {amount}, {finalAmount}");
        }

        private void SendEventLastActivity()
        {
            if (_sdkManagerLastActivity == null || !_sdkManagerLastActivity.HasData()) return;

            _sdkManagerLastActivity.SetSessionDuration(Time.timeSinceLevelLoadAsDouble - _sdkManagerLastActivitySessionTime);
            _sdkManagerLastActivitySessionTime = Time.timeSinceLevelLoadAsDouble;

            string activityJson = JsonUtility.ToJson(_sdkManagerLastActivity);
            var eventParams = Params.New()
                                        .Set(EventParamKeys.Activities, activityJson);
            SendEvent(EventKeys.Game_Last_Activity, eventParams);

            Debug.Log("Game last activities sent!");

            ResetLastActivity();
        }

        private void ResetLastActivity()
        {
            Debug.Log("Game last activities reset.");

            _sdkManagerLastActivity.ResetActivity();
        }

        private void StartJourney(int index)
        {
            SetInterstitialIndex(index);
            SendEventJourneyStarted();
        }

        private void CompleteJourney()
        {
            SendEventJourneyCompleted();
        }
        #endregion

        private void Pause()
        {
            IsPaused = true;

            EventManager.TriggerEvent(new SdkPauseEvent(true));
            Time.timeScale = 0f;
        }

        private void UnPause()
        {
            IsPaused = false;

            Time.timeScale = 1f;
            EventManager.TriggerEvent(new SdkPauseEvent(false));
        }

        public void AddInterstitialBlocker(IInterstitialBlocker blocker)
        {
            _interstitialBlockers.Add(blocker);
        }

        public void RemoveInterstitialBlocker(IInterstitialBlocker blocker)
        {
            _interstitialBlockers.Remove(blocker);
        }

        public void SetNoAdsBoughtStatus(bool isNoAdsBought)
        {
            IsNoAdsBought = isNoAdsBought;
            ProgressManager.Instance.SetSdkDataNoAdsBought(IsNoAdsBought);

            EventManager.TriggerEvent(new SdkNoAdsBoughtEvent(IsNoAdsBought));
        }

        public void OnCGEvent(LevelEvent currentEvent)
        {
            if (currentEvent.EventType == LevelEventType.Opened)
            {
                if (!IsSdkLoadedBefore)
                {
                    ProgressManager.Instance.SetSdkDataIsSdkLoadedBefore(true);
                    StartJourney(InterstitialIndex);
                }

                Debug.Log("SDK Started Listening!");

                IsSDKTimerActive = true;
                IsAdLevelOpened = true;

                ShowBannerConditional();
            }
            /*
            else if (currentEvent.EventType == LevelEventType.Started)
            {

            }
            */
        }

        private void OnEnable()
        {
            this.EventStartListening<LevelEvent>();
        }

        private void OnDisable()
        {
            this.EventStopListening<LevelEvent>();

            SendEventLastActivity();
        }

        private void OnApplicationPause(bool pause)
        {
            if (pause) SendEventLastActivity();
            else ResetLastActivity();
        }

        private void OnApplicationQuit()
        {
            SendEventLastActivity();
        }
    }
}