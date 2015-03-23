


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

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="550B9B1B:666E:5A77B70:550F58B4" name="octolytics-dimension-request_id" /><meta content="10212766" name="octolytics-actor-id" /><meta content="gbelcheva" name="octolytics-actor-login" /><meta content="30554f60b67ae38abc6b6ec5fcb79a6e3dd028cd7a79dc162d701ed1df57a1c7" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="VjKIgx3UKJLGik5nxNh7fJlyWKumkni0x6JQEZD5nHpvaCuVLGF6i/GYzedHY0uhMUqsVOeWR3RWUvrml1LeGQ==" name="csrf-token" />

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
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="Vxx7u86i6P25xj/TOI+wpz0W9wAOBHLEop5WrP6rl75GEOWAcubvVLkV9xNleDdn6UN6tjq9FETkQNJqRZIhmg==" /></div>
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
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="mAhJKv4qZSoUCZur92teEKBt7g05zbNyRkKkwEiyAMyeIZLAPmK3pnb5qyeZ2yzo3XwIV6ZqfehPcjX9w9l0MQ==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="28328936" />

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

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="fOJWgmkxQN1PSex7geBm5HYKAKWRhlQrbVLc8WScFFoTa3w9J3/ABfP5kNVdSLSlqT0vLZrNgS/FXupf4mAzPQ==" /></div>
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
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="q58RqzN2f5E2cnAhqn1/vN40EWCu98PMJ2Cwzts8/zWWDxbASv6csbv6cw3+Ze49uSJdKh2El00/ztZWVjgWVw==" /></div>
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
          

<a href="/TelerikAcademy/CSharp-Part-1/blob/0014f02cd450ad30ac68c34bd467e70367a773a9/2.%20Data%20Types%20and%20Variables/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:a5b9d9dcdb8c7f3c0fed53162c39f497 -->

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
               href="/TelerikAcademy/CSharp-Part-1/blob/master/2.%20Data%20Types%20and%20Variables/README.md"
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
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-1</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1/tree/master/2.%20Data%20Types%20and%20Variables" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">2. Data Types and Variables</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="@NikolayIT" class="avatar" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/NikolayIT" rel="contributor">NikolayIT</a></span>
        <time datetime="2015-01-06T16:31:00Z" is="relative-time">Jan 6, 2015</time>
        <div class="commit-title">
            <a href="/TelerikAcademy/CSharp-Part-1/commit/ea84378e3bb31423b8ec1d8d46a82211c0d14778" class="message" data-pjax="true" title=" Small visual fix in &quot;Data Types and Variables&quot; homework"> Small visual fix in "Data Types and Variables" homework</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>2</strong>
           contributors
        </a>
      </p>
          <a class="avatar-link tooltipped tooltipped-s" aria-label="evlogihr" href="/TelerikAcademy/CSharp-Part-1/commits/master/2.%20Data%20Types%20and%20Variables/README.md?author=evlogihr"><img alt="@evlogihr" class="avatar" data-user="3619393" height="20" src="https://avatars3.githubusercontent.com/u/3619393?v=3&amp;s=40" width="20" /> </a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="NikolayIT" href="/TelerikAcademy/CSharp-Part-1/commits/master/2.%20Data%20Types%20and%20Variables/README.md?author=NikolayIT"><img alt="@NikolayIT" class="avatar" data-user="3106986" height="20" src="https://avatars3.githubusercontent.com/u/3106986?v=3&amp;s=40" width="20" /> </a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="@evlogihr" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
            <a href="/evlogihr">evlogihr</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="@NikolayIT" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
            <a href="/NikolayIT">NikolayIT</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
    <div class="file-actions">

      <div class="btn-group">
        <a href="/TelerikAcademy/CSharp-Part-1/raw/master/2.%20Data%20Types%20and%20Variables/README.md" class="btn btn-sm " id="raw-url">Raw</a>
          <a href="/TelerikAcademy/CSharp-Part-1/blame/master/2.%20Data%20Types%20and%20Variables/README.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
        <a href="/TelerikAcademy/CSharp-Part-1/commits/master/2.%20Data%20Types%20and%20Variables/README.md" class="btn btn-sm " rel="nofollow">History</a>
      </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1?branch=master&amp;filepath=2.%20Data%20Types%20and%20Variables%2FREADME.md"
           aria-label="Open this file in GitHub for Windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

            <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/edit/master/2.%20Data%20Types%20and%20Variables/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="pCVqc2g9LkOCGZVbqwPsC7Nk5jRvV9zjnIt89ihMaosRf/prufQTv1mOexCAEzrcLWi0fPTc8cDFhHJeGLJV0Q==" /></div>
              <button class="octicon-btn tooltipped tooltipped-n" type="submit" aria-label="Clicking this button will fork this project so you can edit the file" data-hotkey="e" data-disable-with>
                <span class="octicon octicon-pencil"></span>
              </button>
</form>
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/delete/master/2.%20Data%20Types%20and%20Variables/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="I5O173VuBibJO0lQqK4Zx96jnGogK+mmyd/50Ul2fgCShmSYoqIV/Wgv5PjBdI+jpTwWgdt/sqOHeZdRxXDb8w==" /></div>
            <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-n" type="submit" aria-label="Fork this project and delete file" data-disable-with>
              <span class="octicon octicon-trashcan"></span>
            </button>
</form>    </div>

    <div class="file-info">
        101 lines (72 sloc)
        <span class="file-info-divider"></span>
      6.296 kb
    </div>
  </div>
    <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-primitive-data-types-and-variables" class="anchor" href="#homework-primitive-data-types-and-variables" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Primitive Data Types and Variables</h1>

<h3>
<a id="user-content-problem-1--declare-variables" class="anchor" href="#problem-1--declare-variables" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1.  Declare Variables</h3>

<ul class="task-list">
<li>  Declare five variables choosing for each of them the most appropriate of the types <code>byte, sbyte, short, ushort, int, uint, long, ulong</code> to represent the following values: <code>52130, -115, 4825932, 97, -10000</code>.</li>
<li>  Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.</li>
</ul>

<p>Submit the source code of your Visual Studio project as part of your homework submission.</p>

<h3>
<a id="user-content-problem-2--float-or-double" class="anchor" href="#problem-2--float-or-double" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2.  Float or Double?</h3>

<ul class="task-list">
<li>  Which of the following values can be assigned to a variable of type <code>float</code> and which to a variable of type <code>double</code>: <code>34.567839023, 12.345, 8923.1234857, 3456.091</code>?</li>
<li>  Write a program to assign the numbers in variables and print them to ensure no precision is lost.</li>
</ul>

<h3>
<a id="user-content-problem-3--variable-in-hexadecimal-format" class="anchor" href="#problem-3--variable-in-hexadecimal-format" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3.  Variable in Hexadecimal Format</h3>

<ul class="task-list">
<li>  Declare an integer variable and assign it with the value <code>254</code> in hexadecimal format (<code>0x##</code>).</li>
<li>  Use Windows Calculator to find its hexadecimal representation.</li>
<li>  Print the variable and ensure that the result is <code>254</code>.</li>
</ul>

<h3>
<a id="user-content-problem-4--unicode-character" class="anchor" href="#problem-4--unicode-character" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4.  Unicode Character</h3>

<ul class="task-list">
<li>  Declare a character variable and assign it with the symbol that has Unicode code <code>42</code> (decimal) using the <code>\u00XX</code> syntax, and then print it.</li>
</ul>

<p>Hint: first, use the Windows Calculator to find the hexadecimal representation of <code>42</code>. The output should be <code>*</code>.</p>

<h3>
<a id="user-content-problem-5--boolean-variable" class="anchor" href="#problem-5--boolean-variable" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5.  Boolean Variable</h3>

<ul class="task-list">
<li>  Declare a Boolean variable called <code>isFemale</code> and assign an appropriate value corresponding to your gender.</li>
<li>  Print it on the console.</li>
</ul>

<h3>
<a id="user-content-problem-6--strings-and-objects" class="anchor" href="#problem-6--strings-and-objects" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6.  Strings and Objects</h3>

<ul class="task-list">
<li>  Declare two string variables and assign them with <code>Hello</code> and <code>World</code>.</li>
<li>  Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).</li>
<li>  Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).</li>
</ul>

<h3>
<a id="user-content-problem-7--quotes-in-strings" class="anchor" href="#problem-7--quotes-in-strings" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7.  Quotes in Strings</h3>

<ul class="task-list">
<li>  Declare two string variables and assign them with following value: <code>The "use" of quotations causes difficulties.</code>
</li>
<li>  Do the above in two different ways - with and without using quoted strings.</li>
<li>  Print the variables to ensure that their value was correctly defined.</li>
</ul>

<h3>
<a id="user-content-problem-8--isosceles-triangle" class="anchor" href="#problem-8--isosceles-triangle" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8.  Isosceles Triangle</h3>

<ul class="task-list">
<li>  Write a program that prints an isosceles triangle of 9 copyright symbols <code>©</code>, something like this:</li>
</ul>

<pre><code>   ©

  © ©

 ©   ©

© © © ©
</code></pre>

<p><em>Note: The <code>©</code> symbol may be displayed incorrectly at the console so you may need to change the console character encoding to <code>UTF-8</code> and assign a Unicode-friendly font in the console.</em></p>

<p><em>Note: Under old versions of Windows the <code>©</code> symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.</em></p>

<h3>
<a id="user-content-problem-9--exchange-variable-values" class="anchor" href="#problem-9--exchange-variable-values" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9.  Exchange Variable Values</h3>

<ul class="task-list">
<li>  Declare two integer variables <code>a</code> and <code>b</code> and assign them with <code>5</code> and <code>10</code> and after that exchange their values by using some programming logic.</li>
<li>  Print the variable values before and after the exchange.</li>
</ul>

<h3>
<a id="user-content-problem-10-employee-data" class="anchor" href="#problem-10-employee-data" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Employee Data</h3>

<p>A marketing company wants to keep record of its employees. Each record would have the following characteristics:</p>

<ul class="task-list">
<li>  First name</li>
<li>  Last name</li>
<li>  Age (0...100)</li>
<li>  Gender (m or f)</li>
<li>  Personal ID number (e.g. 8306112507)</li>
<li>  Unique employee number (27560000…27569999)</li>
</ul>

<p>Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.</p>

<h3>
<a id="user-content-problem-11-bank-account-data" class="anchor" href="#problem-11-bank-account-data" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11. Bank Account Data</h3>

<ul class="task-list">
<li>  A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.</li>
<li>  Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.</li>
</ul>

<h3>
<a id="user-content-problem-12-null-values-arithmetic" class="anchor" href="#problem-12-null-values-arithmetic" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12. Null Values Arithmetic</h3>

<ul class="task-list">
<li>  Create a program that assigns null values to an integer and to a double variable. </li>
<li>  Try to print these variables at the console. </li>
<li>  Try to add some number or the null literal to these variables and print the result.</li>
</ul>

<h3>
<a id="user-content-problem-13----comparing-floats" class="anchor" href="#problem-13----comparing-floats" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 13.*    Comparing Floats</h3>

<ul class="task-list">
<li>  Write a program that safely compares floating-point numbers (double) with precision <code>eps = 0.000001</code>.</li>
</ul>

<p><em>Note: Two floating-point numbers <code>a</code> and <code>b</code> cannot be compared directly by <code>a == b</code> because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant <code>eps</code>.</em></p>

<p>Examples:</p>

<table>
<thead>
<tr>
<th align="center">Number a</th>
<th align="center">Number b</th>
<th align="center">Equal (with precision eps=0.000001)</th>
<th align="center">Explanation</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center">5.3</td>
<td align="center">6.01</td>
<td align="center">false</td>
<td align="center">The difference of 0.71 is too   big (&gt; eps)</td>
</tr>
<tr>
<td align="center">5.00000001</td>
<td align="center">5.00000003</td>
<td align="center">true</td>
<td align="center">The difference 0.00000002 &lt; eps</td>
</tr>
<tr>
<td align="center">5.00000005</td>
<td align="center">5.00000001</td>
<td align="center">true</td>
<td align="center">The difference 0.00000004 &lt; eps</td>
</tr>
<tr>
<td align="center">-0.0000007</td>
<td align="center">0.00000007</td>
<td align="center">true</td>
<td align="center">The difference 0.00000077 &lt; eps</td>
</tr>
<tr>
<td align="center">-4.999999</td>
<td align="center">-4.999998</td>
<td align="center">false</td>
<td align="center">Border case. The difference 0.000001   == eps. We consider the numbers are   different.</td>
</tr>
<tr>
<td align="center">4.999999</td>
<td align="center">4.999998</td>
<td align="center">false</td>
<td align="center">Border case. The difference 0.000001   == eps. We consider the numbers are   different.</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-14----print-the-ascii-table" class="anchor" href="#problem-14----print-the-ascii-table" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 14.*    Print the ASCII Table</h3>

<ul class="task-list">
<li>  Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).</li>
</ul>

<p><em>Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.</em></p>

<p><em>Note: You may need to use for-loops (learn in Internet how).</em></p>
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
      <li>&copy; 2015 <span title="0.04898s from github-fe132-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
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
