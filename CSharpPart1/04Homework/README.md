


<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>CSharp-Part-1/README.md at master · TelerikAcademy/CSharp-Part-1</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="TelerikAcademy/CSharp-Part-1" name="twitter:title" /><meta content="CSharp-Part-1 - Repository for the course &amp;quot;C# part 1&amp;quot;" name="twitter:description" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" property="og:image" /><meta content="TelerikAcademy/CSharp-Part-1" property="og:title" /><meta content="https://github.com/TelerikAcademy/CSharp-Part-1" property="og:url" /><meta content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;" property="og:description" />
      <meta name="browser-stats-url" content="/_stats">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="xhr-socket" href="/_sockets">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="550B9B1B:4D95:51D8938:550F58E4" name="octolytics-dimension-request_id" /><meta content="10212766" name="octolytics-actor-id" /><meta content="gbelcheva" name="octolytics-actor-login" /><meta content="30554f60b67ae38abc6b6ec5fcb79a6e3dd028cd7a79dc162d701ed1df57a1c7" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="Aa2n3WDHC1Jrfj2SMZEuDACEqh+x8wzP9Iooy/7qXPzY6zB2aTi7rKTVYIDSYCAl6nFRLD3vxjilY5HOiTokLw==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-099e0ecc2851c8aca89ef6dafa191df3b0f2a2c8ad34e134c5473ca1ba0a59b2.css" media="all" rel="stylesheet" />
    <link href="https://assets-cdn.github.com/assets/github2-1171344316fc088255ee2a06c271d14240f1a4e06985fe9e897762947872e858.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="c0f32272c66bfb10ed7d46b7c88c6299">

      
  <meta name="description" content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;">
  <meta name="go-import" content="github.com/TelerikAcademy/CSharp-Part-1 git https://github.com/TelerikAcademy/CSharp-Part-1.git">

  <meta content="1455020" name="octolytics-dimension-user_id" /><meta content="TelerikAcademy" name="octolytics-dimension-user_login" /><meta content="28328936" name="octolytics-dimension-repository_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="28328936" name="octolytics-dimension-repository_network_root_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/TelerikAcademy/CSharp-Part-1/commits/master.atom" rel="alternate" title="Recent Commits to CSharp-Part-1:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      


        <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/TelerikAcademy/CSharp-Part-1/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>
      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item explore">
          <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
          </li>
        <li class="header-nav-item">
          <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
        </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/gbelcheva" data-ga-click="Header, go to profile, text:username">
      <img alt="@gbelcheva" class="avatar" data-user="10212766" height="20" src="https://avatars2.githubusercontent.com/u/10212766?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">gbelcheva</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      
<ul class="dropdown-menu">
  <li>
    <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="dropdown-divider"></li>
    <li class="dropdown-header">
      <span title="TelerikAcademy/CSharp-Part-1">This repository</span>
    </li>
      <li>
        <a href="/TelerikAcademy/CSharp-Part-1/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
</ul>

    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="BP9Q2dp1H4T83t0kdHPaNJSQw2g94cjtXo+DBm5S/XFFm7Y55E2sBaQr1Cb6wFkBLj9ZsDi4NeJUxevBD5YYkw==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>


    
  </div>
</div>

        

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

  <li>
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="xdXts4fdTFVZs8+PWyxmZhojyCy09Ru/g8gKoBU+R/fbs/aCg5WSCHxdC2xgPW7NVd+xVsz7+gjyGMZRhRp/0A==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="28328936" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/TelerikAcademy/CSharp-Part-1/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Watch
          </span>
        </a>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/watchers">
          20
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="NOcRQjzV6qDTMxqi8t3aLEYD6fPu5zBAVn598GELWXypbh4cAda8naRXInVuGIPwkDQV9iuKpYoZk5VgTxxljg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="qmNMvd1qNIxpdMLI1mIpWj3pHbJjXCjQmlmNpH+ZZ0H9PFleJhqXGKrXOB6ho6m1+IaXRXGyU8T1BJpQwmeZPQ==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>  </div>

  </li>

        <li>
          <a href="#fork-destination-box" class="btn btn-sm btn-with-count"
              title="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              aria-label="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              rel="facebox"
              data-ga-click="Repository, show fork modal, action:blob#show; text:Fork">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/TelerikAcademy/CSharp-Part-1/network" class="social-count">37</a>

          <div id="fork-destination-box" style="display: none;">
            <h2 class="facebox-header">Where should we fork this repository?</h2>
            <include-fragment src=""
                class="js-fork-select-fragment fork-select-fragment"
                data-url="/TelerikAcademy/CSharp-Part-1/fork?fragment=1">
              <img alt="Loading" height="64" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-128-338974454bb5c32803e82f601beb051d373744b024fe8742a76009700fd7e033.gif" width="64" />
            </include-fragment>
          </div>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/TelerikAcademy" class="url fn" itemprop="url" rel="author"><span itemprop="title">TelerikAcademy</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/TelerikAcademy/CSharp-Part-1" class="js-current-repository" data-pjax="#js-repo-pjax-container">CSharp-Part-1</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/TelerikAcademy/CSharp-Part-1/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/TelerikAcademy/CSharp-Part-1" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /TelerikAcademy/CSharp-Part-1">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/TelerikAcademy/CSharp-Part-1/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /TelerikAcademy/CSharp-Part-1/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/TelerikAcademy/CSharp-Part-1/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /TelerikAcademy/CSharp-Part-1/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>


  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/TelerikAcademy/CSharp-Part-1/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /TelerikAcademy/CSharp-Part-1/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/TelerikAcademy/CSharp-Part-1/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /TelerikAcademy/CSharp-Part-1/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<p class="clone-options">You can clone with
  <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>, <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>, or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1" class="btn btn-sm sidebar-button" title="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop." aria-label="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/TelerikAcademy/CSharp-Part-1/archive/master.zip"
                   class="btn btn-sm sidebar-button"
                   aria-label="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   title="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/TelerikAcademy/CSharp-Part-1/blob/0014f02cd450ad30ac68c34bd467e70367a773a9/4.%20Console%20In%20and%20Out/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:35d10aa63488de4039f9b3c0e21a6d21 -->

<div class="file-navigation js-zeroclipboard-container">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/TelerikAcademy/CSharp-Part-1/blob/master/4.%20Console%20In%20and%20Out/README.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

  <div class="btn-group right">
    <a href="/TelerikAcademy/CSharp-Part-1/find/master"
          class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
  </div>

  <div class="breadcrumb js-zeroclipboard-target">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-1</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1/tree/master/4.%20Console%20In%20and%20Out" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">4. Console In and Out</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="evlogihr" class="avatar" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/evlogihr" rel="contributor">evlogihr</a></span>
        <time datetime="2015-01-26T09:48:05Z" is="relative-time">Jan 26, 2015</time>
        <div class="commit-title">
            <a href="/TelerikAcademy/CSharp-Part-1/commit/08867ac4f7800fada07d65c0bd6cfca741b06a7c" class="message" data-pjax="true" title="Fix for problem 2. user input">Fix for problem 2. user input</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>3</strong>
           contributors
        </a>
      </p>
          <a class="avatar-link tooltipped tooltipped-s" aria-label="evlogihr" href="/TelerikAcademy/CSharp-Part-1/commits/master/4.%20Console%20In%20and%20Out/README.md?author=evlogihr"><img alt="evlogihr" class="avatar" data-user="3619393" height="20" src="https://avatars3.githubusercontent.com/u/3619393?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="NikolayIT" href="/TelerikAcademy/CSharp-Part-1/commits/master/4.%20Console%20In%20and%20Out/README.md?author=NikolayIT"><img alt="Nikolay Kostov" class="avatar" data-user="3106986" height="20" src="https://avatars3.githubusercontent.com/u/3106986?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="aleksandra992" href="/TelerikAcademy/CSharp-Part-1/commits/master/4.%20Console%20In%20and%20Out/README.md?author=aleksandra992"><img alt="Aleksandra" class="avatar" data-user="3929626" height="20" src="https://avatars1.githubusercontent.com/u/3929626?v=3&amp;s=40" width="20" /></a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="evlogihr" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
            <a href="/evlogihr">evlogihr</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Nikolay Kostov" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
            <a href="/NikolayIT">NikolayIT</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Aleksandra" data-user="3929626" height="24" src="https://avatars3.githubusercontent.com/u/3929626?v=3&amp;s=48" width="24" />
            <a href="/aleksandra992">aleksandra992</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
    <div class="file-actions">

      <div class="btn-group">
        <a href="/TelerikAcademy/CSharp-Part-1/raw/master/4.%20Console%20In%20and%20Out/README.md" class="btn btn-sm " id="raw-url">Raw</a>
          <a href="/TelerikAcademy/CSharp-Part-1/blame/master/4.%20Console%20In%20and%20Out/README.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
        <a href="/TelerikAcademy/CSharp-Part-1/commits/master/4.%20Console%20In%20and%20Out/README.md" class="btn btn-sm " rel="nofollow">History</a>
      </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1?branch=master&amp;filepath=4.%20Console%20In%20and%20Out%2FREADME.md"
           aria-label="Open this file in GitHub for Windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

            <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/edit/master/4.%20Console%20In%20and%20Out/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="KTd32JW27syvkHd/q7btNjdqzTV8c5E11NtNlEMVOgO2/5Asfak81bnie2t+SORW6LegT1S38D5+UGqXyp5EPw==" /></div>
              <button class="octicon-btn tooltipped tooltipped-n" type="submit" aria-label="Clicking this button will fork this project so you can edit the file" data-hotkey="e" data-disable-with>
                <span class="octicon octicon-pencil"></span>
              </button>
</form>
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/delete/master/4.%20Console%20In%20and%20Out/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="cC8+W70/QTDU8JtZbWpfCUx1YrO7pHgsFrKSwCZ16QSOKcXGJpb7t1Zi1wbntQRr//bBV2kD99QVAGIxKpO3Ew==" /></div>
            <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-n" type="submit" aria-label="Fork this project and delete file" data-disable-with>
              <span class="octicon octicon-trashcan"></span>
            </button>
</form>    </div>

    <div class="file-info">
        188 lines (146 sloc)
        <span class="file-info-divider"></span>
      7.317 kb
    </div>
  </div>
    <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-console-input--output" class="anchor" href="#homework-console-input--output" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Console Input / Output</h1>

<h3>
<a id="user-content-problem-1--sum-of-3-numbers" class="anchor" href="#problem-1--sum-of-3-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1.  Sum of 3 Numbers</h3>

<ul class="task-list">
<li>  Write a program that reads 3 real numbers from the console and prints their sum.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">a</th>
<th align="center">b</th>
<th align="center">c</th>
<th align="center">sum</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">3</td>
<td align="center">4</td>
<td align="center">11</td>
<td align="center">18</td>
</tr>
<tr>
<td align="center">-2</td>
<td align="center">0</td>
<td align="center">3</td>
<td align="center">1</td>
</tr>
<tr>
<td align="center">5.5</td>
<td align="center">4.5</td>
<td align="center">20.1</td>
<td align="center">30.1</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-2--print-company-information" class="anchor" href="#problem-2--print-company-information" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2.  Print Company Information</h3>

<ul class="task-list">
<li>  A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.</li>
<li>  Write a program that reads the information about a company and its manager and prints it back on the console.</li>
</ul>

<p><em>Example input:</em></p>

<table>
<thead>
<tr>
<th>program</th>
<th>user</th>
</tr>
</thead>
<tbody>
<tr>
<td>Company name:</td>
<td>Telerik Academy</td>
</tr>
<tr>
<td>Company address:</td>
<td>31 Al. Malinov, Sofia</td>
</tr>
<tr>
<td>Phone number:</td>
<td>+359 888 55 55 555</td>
</tr>
<tr>
<td>Fax number:</td>
<td></td>
</tr>
<tr>
<td>Web site:</td>
<td><a href="http://telerikacademy.com/">http://telerikacademy.com/</a></td>
</tr>
<tr>
<td>Manager first name:</td>
<td>Nikolay</td>
</tr>
<tr>
<td>Manager last name:</td>
<td>Kostov</td>
</tr>
<tr>
<td>Manager age:</td>
<td>25</td>
</tr>
<tr>
<td>Manager phone:</td>
<td>+359 2 981 981</td>
</tr>
</tbody>
</table>

<p><em>Example output:</em></p>

<pre><code>Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
</code></pre>

<h3>
<a id="user-content-problem-3--circle-perimeter-and-area" class="anchor" href="#problem-3--circle-perimeter-and-area" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3.  Circle Perimeter and Area</h3>

<ul class="task-list">
<li>  Write a program that reads the radius <code>r</code> of a circle and prints its perimeter and area formatted with <code>2</code> digits after the decimal point.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">r</th>
<th align="center">perimeter</th>
<th align="center">area</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">2</td>
<td align="center">12.57</td>
<td align="center">12.57</td>
</tr>
<tr>
<td align="center">3.5</td>
<td align="center">21.99</td>
<td align="center">38.48</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-4--number-comparer" class="anchor" href="#problem-4--number-comparer" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4.  Number Comparer</h3>

<ul class="task-list">
<li>  Write a program that gets two numbers from the console and prints the greater of them.</li>
<li>  Try to implement this without if statements.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">a</th>
<th align="center">b</th>
<th align="center">greater</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">5</td>
<td align="center">6</td>
<td align="center">6</td>
</tr>
<tr>
<td align="center">10</td>
<td align="center">5</td>
<td align="center">10</td>
</tr>
<tr>
<td align="center">0</td>
<td align="center">0</td>
<td align="center">0</td>
</tr>
<tr>
<td align="center">-5</td>
<td align="center">-2</td>
<td align="center">-2</td>
</tr>
<tr>
<td align="center">1.5</td>
<td align="center">1.6</td>
<td align="center">1.6</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-5--formatting-numbers" class="anchor" href="#problem-5--formatting-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5.  Formatting Numbers</h3>

<ul class="task-list">
<li>  Write a program that reads 3 numbers:

<ul class="task-list">
<li>  integer <code>a</code> (0 &lt;= a &lt;= 500)</li>
<li>  floating-point <code>b</code>
</li>
<li>  floating-point <code>c</code> </li>
</ul>
</li>
<li>  The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 

<ul class="task-list">
<li>  The number <code>a</code> should be printed in hexadecimal, left aligned</li>
<li>  Then the number <code>a</code> should be printed in binary form, padded with zeroes</li>
<li>  The number <code>b</code> should be printed with 2 digits after the decimal point, right aligned</li>
<li>  The number c should be printed with 3 digits after the decimal point, left aligned. </li>
</ul>
</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">a</th>
<th align="center">b</th>
<th align="center">c</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">254</td>
<td align="center">11.6</td>
<td align="center">0.5</td>
<td><code>FE        |0011111110|     11.60|0.500     |</code></td>
</tr>
<tr>
<td align="center">499</td>
<td align="center">-0.5559</td>
<td align="center">10000</td>
<td><code>1F3       |0111110011|     -0.56|10000.000 |</code></td>
</tr>
<tr>
<td align="center">0</td>
<td align="center">3</td>
<td align="center">-0.1234</td>
<td><code>0         |0000000000|      3.00|-0.123    |</code></td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-6--quadratic-equation" class="anchor" href="#problem-6--quadratic-equation" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6.  Quadratic Equation</h3>

<ul class="task-list">
<li>  Write a program that reads the coefficients <code>a</code>, <code>b</code> and <code>c</code> of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">a</th>
<th align="center">b</th>
<th align="center">c</th>
<th>roots</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">2</td>
<td align="center">5</td>
<td align="center">-3</td>
<td>x1=-3; x2=0.5</td>
</tr>
<tr>
<td align="center">-1</td>
<td align="center">3</td>
<td align="center">0</td>
<td>x1=3; x2=0</td>
</tr>
<tr>
<td align="center">-0.5</td>
<td align="center">4</td>
<td align="center">-8</td>
<td>x1=x2=4</td>
</tr>
<tr>
<td align="center">5</td>
<td align="center">2</td>
<td align="center">8</td>
<td>no real roots</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-7--sum-of-5-numbers" class="anchor" href="#problem-7--sum-of-5-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7.  Sum of 5 Numbers</h3>

<ul class="task-list">
<li>  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>numbers</th>
<th>sum</th>
</tr>
</thead>
<tbody>
<tr>
<td>1 2 3 4 5</td>
<td>15</td>
</tr>
<tr>
<td>10 10 10 10 10</td>
<td>50</td>
</tr>
<tr>
<td>1.5 3.14 8.2 -1 0</td>
<td>11.84</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-8--numbers-from-1-to-n" class="anchor" href="#problem-8--numbers-from-1-to-n" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8.  Numbers from 1 to n</h3>

<ul class="task-list">
<li>  Write a program that reads an integer number <code>n</code> from the console and prints all the numbers in the interval <code>[1..n]</code>, each on a single line.</li>
</ul>

<p><em>Note: You may need to use a for-loop.</em></p>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>output</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>1</td>
</tr>
<tr>
<td></td>
<td>2</td>
</tr>
<tr>
<td></td>
<td>3</td>
</tr>
<tr>
<td>5</td>
<td>1</td>
</tr>
<tr>
<td></td>
<td>2</td>
</tr>
<tr>
<td></td>
<td>3</td>
</tr>
<tr>
<td></td>
<td>4</td>
</tr>
<tr>
<td></td>
<td>5</td>
</tr>
<tr>
<td>1</td>
<td>1</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-9--sum-of-n-numbers" class="anchor" href="#problem-9--sum-of-n-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9.  Sum of n Numbers</h3>

<ul class="task-list">
<li>  Write a program that enters a number <code>n</code> and after that enters more <code>n</code> numbers and calculates and prints their <code>sum</code>.
<em>Note: You may need to use a for-loop.</em>
</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>numbers</th>
<th>sum</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>90</td>
</tr>
<tr>
<td>20</td>
<td></td>
</tr>
<tr>
<td>60</td>
<td></td>
</tr>
<tr>
<td>10</td>
<td></td>
</tr>
<tr>
<td>5</td>
<td>6.5</td>
</tr>
<tr>
<td>2</td>
<td></td>
</tr>
<tr>
<td>-1</td>
<td></td>
</tr>
<tr>
<td>-0.5</td>
<td></td>
</tr>
<tr>
<td>4</td>
<td></td>
</tr>
<tr>
<td>2</td>
<td></td>
</tr>
<tr>
<td>1</td>
<td>1</td>
</tr>
<tr>
<td>1</td>
<td></td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-10-fibonacci-numbers" class="anchor" href="#problem-10-fibonacci-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Fibonacci Numbers</h3>

<ul class="task-list">
<li>  Write a program that reads a number <code>n</code> and prints on the console the first <code>n</code> members of the Fibonacci sequence (at a single line, separated by comma and space - <code>,</code>) : <code>0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …</code>.</li>
</ul>

<p><em>Note: You may need to learn how to use loops.</em></p>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">n</th>
<th>comments</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">1</td>
<td>0</td>
</tr>
<tr>
<td align="center">3</td>
<td>0 1 1</td>
</tr>
<tr>
<td align="center">10</td>
<td>0 1 1 2 3 5 8 13 21 34</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-11-numbers-in-interval-dividable-by-given-number" class="anchor" href="#problem-11-numbers-in-interval-dividable-by-given-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11.* Numbers in Interval Dividable by Given Number</h3>

<ul class="task-list">
<li>  Write a program that reads two positive integer numbers and prints how many numbers <code>p</code> exist between them such that the reminder of the division by <code>5</code> is <code>0</code>.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th align="center">start</th>
<th align="center">end</th>
<th align="center">p</th>
<th>comments</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">17</td>
<td align="center">25</td>
<td align="center">2</td>
<td>20, 25</td>
</tr>
<tr>
<td align="center">5</td>
<td align="center">30</td>
<td align="center">6</td>
<td>5, 10, 15, 20, 25, 30</td>
</tr>
<tr>
<td align="center">3</td>
<td align="center">33</td>
<td align="center">6</td>
<td>5, 10, 15, 20, 25, 30</td>
</tr>
<tr>
<td align="center">3</td>
<td align="center">4</td>
<td align="center">0</td>
<td>-</td>
</tr>
<tr>
<td align="center">99</td>
<td align="center">120</td>
<td align="center">5</td>
<td>100, 105, 110, 115, 120</td>
</tr>
<tr>
<td align="center">107</td>
<td align="center">196</td>
<td align="center">18</td>
<td>110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-12-falling-rocks" class="anchor" href="#problem-12-falling-rocks" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12.** Falling Rocks</h3>

<ul class="task-list">
<li>  Implement the "Falling Rocks" game in the text console.

<ul class="task-list">
<li>  A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).<br>
</li>
<li>  A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.<br>
</li>
<li>  Rocks are the symbols <code>^, @, *, &amp;, +, %, $, #, !, ., ;, -</code> distributed with appropriate density. The dwarf is <code>(O)</code>.</li>
</ul>
</li>
<li>  Ensure a constant game speed by <code>Thread.Sleep(150)</code>.</li>
<li>  Implement collision detection and scoring system.</li>
</ul>

<p><a href="https://cloud.githubusercontent.com/assets/3106986/5611219/7126b0b6-94cc-11e4-8610-28ffa78d0cf7.png" target="_blank"><img src="https://cloud.githubusercontent.com/assets/3106986/5611219/7126b0b6-94cc-11e4-8610-28ffa78d0cf7.png" alt="console-falling-rocks" style="max-width:100%;"></a></p>

<h3>
<a id="user-content-more-c-console-games" class="anchor" href="#more-c-console-games" aria-hidden="true"><span class="octicon octicon-link"></span></a>More C# console games:</h3>

<p><a href="https://github.com/NikolayIT/CSharpConsoleGames">github.com/NikolayIT/CSharpConsoleGames</a></p>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="btn">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.05310s from github-fe120-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
    </ul>
  </div>
</div>


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-d22b59d0085e83b7549ba4341ec9e68f80c2f29c8e49213ee182003dc8d568c6.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-0bc0f45c838b5d9d25bc071d2a4b0abe759a093392087dce55cd2caa00ea4f36.js"></script>
      
      

  </body>
</html>

